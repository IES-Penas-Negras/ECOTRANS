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
      
     ///////////////////////////TEST LISTAR//////////////////////////////////////////////////////////

        [Fact]
        public void Listar_Una_Ciudad()
        {
            // Given
            
            var ciudad = new Ciudad()
            {
                Nombre= "París"
            };
        
            // When
        
            var peticion = new ListarCiudadRequest();
            var respuesta = accionesCiudades.Listar(peticion);
        
            respuesta= accionesCiudades.Listar(peticion);

            // Then
            
            Assert.NotEmpty(respuesta.Elementos);
            Assert.Equal(respuesta.Elementos.First().Nombre, ciudad.Nombre);
            
        }

     //////////////////////////TEST CREAR////////////////////////////////////////////////////////////

        [Fact]
        public void Crear_Una_Ciudad()
        {
            // Given
            
            var ciudad = new Ciudad()
            {
                Nombre= "París"
            };
        

            // When
            var peticion= new CrearCiudadRequest();
            var respuesta= accionesCiudades.Crear(peticion);

            // Then
            Assert.True(respuesta.Id>0);
            Assert.Equal(respuesta.Nombre, ciudad.Nombre);
        }

     [Fact]

        public void Editar_Una_Ciudad_Existente()
        {

        }

     [Fact]

        public void Borrar_Una_Ciudad()
        {
            
    

        }
    } 
