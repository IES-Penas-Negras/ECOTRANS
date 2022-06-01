using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.TipoObjeto
{
    public class AccionesTipoObjeto
    {
        public CrearTipoObjetoResponse Crear(CrearTipoObjetoRequest crearTipoObjetoRequest)
        {
            return new CrearTipoObjetoResponse();
        }

        public EditarTipoObjetoResponse Editar(EditarTipoObjetoRequest editarTipoObjetoRequest)
        {
            return new EditarTipoObjetoResponse();

        }

        public ListarTipoObjetoResponse Listar(ListarTipoObjetoRequest listarTipoObjetoRequest)
        {
            return new ListarTipoObjetoResponse();
        }

        public void Borrar(BorrarTipoObjetoRequest borrarTipoObjetoRequest)
        {
            
        }

    }
}
