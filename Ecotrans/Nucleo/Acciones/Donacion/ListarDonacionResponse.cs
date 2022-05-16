using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Donacion
{
    public class ListarDonacionResponse
    {
        public List<ListaDonacionElemento> Elementos { get; set; }
    }

    public class ListaDonacionElemento
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
    