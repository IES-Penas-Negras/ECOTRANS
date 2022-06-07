using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESPeniasNegras.Ecotrans.Nucleo.Model
{
    public class ObjetoDonacion
    {
        public int Id { get; set; }
        public int ObjetoId { get; set; }
        public int DonacionId { get; set; }
        public Objeto Objeto { get; set; }
        public Donacion Donacion { get; set; }
    }
}
