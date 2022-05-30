using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Donacion;

    public class ListarDonacionRequest
    {
        public ListarDonacionRequest(string? buscar = null)
        {
            Buscar = buscar;
        }
        public string? Buscar { get; set; }
    }

