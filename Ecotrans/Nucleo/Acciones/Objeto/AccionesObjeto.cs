
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Objeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecotrans.Nucleo.BBDD;
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Objeto;

namespace IESPeniasNegras.Ecotrans.Nucleo.AccionesObjeto;

    public class AccionesObjeto
    {
        private readonly DonacionesContext contexto;

        public AccionesObjeto()
        {
            contexto = new DonacionesContext();
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

