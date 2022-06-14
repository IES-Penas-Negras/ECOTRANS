using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Ciudades;
using IESPeniasNegras.Ecotrans.Nucleo.Model;
using Xunit;

namespace IESPeniasNegras.Ecotrans.Test;


    public class CiudadesTests 
    {

        private readonly DonacionesTestContext contexto;
        private readonly AccionesCiudades accionesCiudades;

        public  CiudadesTests()
        {          
            contexto = new DonacionesTestContext();    
            accionesCiudades= new AccionesCiudades(contexto);
        }
      
       #region "test para listar"

        [Fact]
        public void Listar_Una_Ciudad()
        {
            // (Dado que) Given
            
            var ciudad = new Ciudad()
            {
                Nombre= "París"
            };

            contexto.Ciudades.Add(ciudad);
            contexto.SaveChanges();
        
            // (Cuando) When
        
            var peticion = new ListarCiudadRequest();
            var respuesta = accionesCiudades.Listar(peticion);
        

            // (Entonces) Then
            
            Assert.NotEmpty(respuesta.Elementos);
            Assert.Equal(respuesta.Elementos.Single().Nombre, ciudad.Nombre);
            
        }
        #endregion

        #region "test para crear"

        [Fact]
        public void Crear_Una_Ciudad()
        {
            // (Dado) Given
            
            var ciudad = new Ciudad()
            {
                Nombre= "París"
            };

            // (Cuando) When

            var peticion= new CrearCiudadRequest(ciudad.Nombre);
            var respuesta= accionesCiudades.Crear(peticion);

            // (Entonces) Then

            Assert.True(respuesta.Id>0);
            Assert.Equal(respuesta.Nombre, ciudad.Nombre);
        }
        #endregion
    
        #region "test para editar"

        [Fact]

        public void Editar_Una_Ciudad_Existente()
        {
             // (Dado que) Given
            
            var ciudad = new Ciudad()
            {
                Nombre= "París"
            };

            contexto.Ciudades.Add(ciudad);
            contexto.SaveChanges();
        
            // (Cuando) When

            var peticion= new EditarCiudadRequest("Roma", ciudad.Id);
            var respuesta= accionesCiudades.Editar(peticion);

            // (Entonces) Then

            Assert.Equal(respuesta.Id, ciudad.Id);
            Assert.Equal(respuesta.Nombre, "Roma");

        }
        #endregion

        #region "test para borrar"

         [Fact]

        public void Borrar_Una_Ciudad()
        {
              // (Dado que) Given
            
            var ciudad = new Ciudad()
            {
                Nombre= "París"
            };

            contexto.Ciudades.Add(ciudad);
            contexto.SaveChanges();
        
            // (Entonces) When

            var peticion= new BorrarCiudadRequest(ciudad.Id);
            accionesCiudades.Borrar(peticion);

           // (Cuando) Then
           
            var ciudadesDBContext= contexto.Ciudades.SingleOrDefault(o => o.Id==ciudad.Id);
            Assert.Null(ciudadesDBContext);

        }
        #endregion
    } 


        