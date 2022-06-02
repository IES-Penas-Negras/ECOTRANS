using IESPeniasNegras.Ecotrans.Nucleo.Acciones.TipoObjeto;
using IESPeniasNegras.Ecotrans.Nucleo.Model;
using IESPeniasNegras.Ecotrans.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace IESPeniasNegras.Ecotrans.TestUnitarios
{
    public class TipoObjetoTest
    {
        private readonly DonacionesTestContext contexto;
        private readonly AccionesTipoObjeto accionesTipoObjetoObjeto;
        public TipoObjetoTest()
        {
            contexto = new DonacionesTestContext();
            accionesTipoObjetoObjeto = new AccionesTipoObjeto(contexto); 
        }

        [Fact]
        public void Debe_Crear_Tipo_Objeto()
        {
            // ARRANGE
            var crearTipoObjeto = new TipoObjeto()
            {
                Nombre = "Vehículo"
            };
            // ACT
            var peticion = new CrearTipoObjetoRequest()
            {
                Nombre = crearTipoObjeto.Nombre 
            };
            var respuesta = accionesTipoObjetoObjeto.Crear(peticion);
            // ASSERT
            Assert.Equal(respuesta.Nombre, crearTipoObjeto.Nombre);
        }
       [Fact]
        public void Debe_Editar_Tipo_Objeto_Existente()
        {
            // ARRANGE
            var editarTipoObjeto = new TipoObjeto()
            {
                Nombre = "Vehículo"
            };
            // añadir a la base de datos(DbSet?)
            // ACT
            var peticion = new EditarTipoObjetoRequest()
            {
                IdEdicion = editarTipoObjeto.Id,
                Nombre = "Electrodoméstico"
            };
            var respuesta = accionesTipoObjetoObjeto.Editar(peticion);
            // ASSERT
            Assert.NotEqual(respuesta.Nombre, editarTipoObjeto.Nombre);
            Assert.Equal(respuesta.Id, editarTipoObjeto.Id);
        }
        /*[Fact]
        public void Debe_Listar_Tipo_Objeto_Existente()
        {
            // ARRANGE
            var listarTipoObjeto = new TipoObjeto()
            {
                Nombre = "Bicicleta"
            };

            // ACT
            var peticion = new ListarTipoObjetoRequest();
            var respuesta = accionesTipoObjetoObjeto.Listar(peticion);

            // ASSERT
            Assert.NotEmpty(respuesta.Elementos);

        }
        [Fact]
        public void Debe_Borrar_Tipo_Objeto_Existente()
        {
            // ARRANGE
            var borrarTipoObjeto = new TipoObjeto()
            {
                Nombre = "Bicicleta"
            };
            // ACT
            var peticion = new BorrarTipoObjetoRequest(borrarTipoObjeto.Id);
            accionesTipoObjetoObjeto.Borrar(peticion);
            // ASSERT
            
        }*/
    }
}
