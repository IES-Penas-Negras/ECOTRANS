using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESPeñasNegras.Ecotrans.Nucleo.Acciones.Objeto
{
    internal class AccionesObjeto
    {
        public void Crear() { }
        public void Listar() { }
        public EditarObjetoResponse Editar(EditarObjetoRequest editar) 
        {
            EditarObjetoResponse response = new EditarObjetoResponse();
            return response;
        }
        public void Borrar() { }

    }
}
