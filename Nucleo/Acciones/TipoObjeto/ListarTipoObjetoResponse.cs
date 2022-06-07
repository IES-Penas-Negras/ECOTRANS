using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.TipoObjeto
{
   
    public class ListarTipoObjetoResponse
    {
        public ListarTipoObjetoResponse(List<ListarTipoObjetoElemento> tipoObjetos)
        {
            Elementos = tipoObjetos;
        }

        public List<ListarTipoObjetoElemento> Elementos { get; set; }

    }
    public class ListarTipoObjetoElemento
    {
        public string Nombre { get; set; }
        public int Id { get; set; }
    }
}
