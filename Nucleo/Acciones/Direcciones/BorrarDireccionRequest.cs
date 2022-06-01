using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Direcciones
{
    public class BorrarDireccionRequest
    {
        public BorrarDireccionRequest(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
