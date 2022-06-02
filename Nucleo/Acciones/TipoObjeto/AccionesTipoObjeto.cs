using AutoMapper;
using IESPeniasNegras.Ecotrans.Nucleo.BBDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.TipoObjeto
{
    public class AccionesTipoObjeto
    {
        private readonly DonacionesContext contexto;
        private readonly IMapper mapper;
        public AccionesTipoObjeto (DonacionesContext? donacionesContext = null, IMapper? mapper = null)
        {
            if (donacionesContext == null)
            {
                contexto = new DonacionesContext();
            }
            else
            {
                contexto = donacionesContext;
            }

            this.mapper = mapper ?? new MapperConfiguration(cfg => cfg.AddProfile<TiposObjetoProfile>()).CreateMapper();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }
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
