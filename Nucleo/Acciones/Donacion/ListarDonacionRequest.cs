using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Donacion;

    public class ListarDonacionRequest
    {
        public string? Buscar { get; set; }
        public ListarDonacionRequest(string? buscar = null)
        {
            Buscar = buscar;
        }
    }

