using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Direcciones
{
    public class ListarDireccionRequest
    {
        public ListarDireccionRequest(string? buscar)
        {
            Buscar = buscar;
        }

        public string? Buscar { get; set; }
    }
}
