
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Objeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IESPeniasNegras.Ecotrans.Nucleo.BBDD;


namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Objeto
{
    public class AccionesObjeto : IDisposable
    {
        private readonly DonacionesContext contexto;
        private readonly IMapper mapper;

        public AccionesObjeto(DonacionesContext? donacionesContext = null, IMapper? mapper = null)
        {
            if (donacionesContext == null)
            {
                contexto = new DonacionesContext();
            }
            else
            {
                contexto = donacionesContext;
            }

            this.mapper = mapper ?? new AutoMapper();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public CrearObjetoResponse Crear(CrearObjetoRequest crearObjetoRequest)
        {
            return new CrearObjetoResponse();
            var objeto = mapper.Map<Objeto>(crearObjetoRequest);
            
        }

        public EditarObjetoResponse Editar(EditarObjetoRequest editar)
        {
            EditarObjetoResponse response = new EditarObjetoResponse();
            return response;
        }

        public ListarObjetoResponse Listar(ListarObjetoRequest listarObjetoRequest)
        {
            return new ListarObjetoResponse();

        }

        public void Borrar(BorrarObjetoRequest borrar) { }

    }
}

