using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecotrans.Nucleo.BBDD;
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Objeto;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Objeto
{
    public class AccionesObjeto : IDisposable
    {
        private readonly DonacionesContext contexto;

        public AccionesObjeto(DonacionesContext? donacionesContext=null)
        {
            if (donacionesContext == null)
            {
                contexto = new DonacionesContext();
            }
            else
            {
                contexto = donacionesContext;
            }
            
        }

        public void Dispose ()
        {
            contexto.Dispose();
        }

        public CrearObjetoResponse Crear(CrearObjetoRequest crearObjetoRequest) 
        {
            return new CrearObjetoResponse();
        }
       
        public EditarObjetoResponse Editar(EditarObjetoRequest editar) 
        {
            EditarObjetoResponse response = new EditarObjetoResponse();
            return response;
        }
        
        public ListarObjetoResponse Listar(ListarObjetoRequest listarObjetoRequest ) 
        { 
            return new ListarObjetoResponse(); 
            
        }

        public void Borrar(BorrarObjetoRequest borrar) { }

    }
}
