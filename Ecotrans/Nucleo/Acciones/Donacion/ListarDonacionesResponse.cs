using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESPeñasNegras.Ecotrans.Nucleo.Acciones.Donacion
{
    public class ListarDonacionesResponse
    {
        public List<ListarDonacionesElemento> Elementos { get; set; }
    }

    public class ListarDonacionesElemento
    {
       
        public string Nombre { get; set; }
        public int TipoObjetoID { get; set; }
        public Estado Estado { get; set;}
        public decimal Altura { get; set; }
        public decimal Anchura { get; set; }
        public decimal Profundidad { get; set; }
        public decimal Peso { get; set; }

    }
}
    