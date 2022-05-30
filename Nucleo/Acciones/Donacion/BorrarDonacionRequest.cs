using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Donacion
{
    public class BorrarDonacionRequest
    {
        public BorrarDonacionRequest(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
