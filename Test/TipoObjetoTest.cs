using IESPeniasNegras.Ecotrans.Nucleo.Acciones.TipoObjeto;
using IESPeniasNegras.Ecotrans.Nucleo.Model;
using IESPeniasNegras.Ecotrans.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace IESPeniasNegras.Ecotrans.Test
{
    public class TipoObjetoTest
    {
        private readonly DonacionesTestContext contexto;
        private readonly AccionesTipoObjeto accionesTipoObjeto;
        public TipoObjetoTest()
        {
            contexto = new DonacionesTestContext();
            accionesTipoObjeto = new AccionesTipoObjeto(contexto); 
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
            var respuesta = accionesTipoObjeto.Crear(peticion);

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
            contexto.TiposObjetos.Add(editarTipoObjeto);
            contexto.SaveChanges();

            // ACT
            var peticion = new EditarTipoObjetoRequest()
            {
                IdEdicion = editarTipoObjeto.Id,
                Nombre = "Electrodoméstico"
            };
            var respuesta = accionesTipoObjeto.Editar(peticion);

            // ASSERT
            Assert.Equal(respuesta.Nombre, editarTipoObjeto.Nombre);
            Assert.Equal(respuesta.Id, editarTipoObjeto.Id);
        }
        [Fact]
        public void Debe_Listar_Tipo_Objeto_Existente()
        {
            // ARRANGE
            var listarTipoObjeto = new TipoObjeto()
            {
                Nombre = "Bicicleta"
            };
            contexto.TiposObjetos.Add(listarTipoObjeto);
            contexto.SaveChanges();

            // ACT
            var peticion = new ListarTipoObjetoRequest();
            var respuesta = accionesTipoObjeto.Listar(peticion);

            // ASSERT
            Assert.NotEmpty(respuesta.Elementos);

        }
        [Fact]
        public void Debe_Borrar_Tipo_Objeto_Existente()
        {
            // ARRANGE
            var borrarTipoObjeto = new TipoObjeto()
            {
                Nombre = "Vehículo"
            };
            contexto.TiposObjetos.Add(borrarTipoObjeto);
            contexto.SaveChanges();

            // ACT
            var peticion = new BorrarTipoObjetoRequest(borrarTipoObjeto.Id);
            accionesTipoObjeto.Borrar(peticion);

            // ASSERT
            var tipoObjetoDB = contexto.TiposObjetos.SingleOrDefault(o => o.Id == borrarTipoObjeto.Id);
            Assert.Null(tipoObjetoDB);
        }
        [Fact]
        public void No_Debe_Listar_Tipo_Objeto_Cuando_No_Se_Busca()
        {
            //ARRANGE
            var noListarTipoObjeto = new TipoObjeto()
            {
                Nombre = "Vehículo"
            };
            contexto.TiposObjetos.Add(noListarTipoObjeto);
            contexto.SaveChanges();

            //ACT
            var peticion = new ListarTipoObjetoRequest()
            {
                Buscar = "Electrodoméstico"
            };
            var respuesta = accionesTipoObjeto.Listar(peticion);

            //ASSERT
            Assert.Empty(respuesta.Elementos);
        }
    }
}
