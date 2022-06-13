using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Objeto;

public class ListarObjetoRequest 
{
    public string? Buscar { get; set; }

    public ListarObjetoRequest(string? buscar = null) 
    {
        Buscar = buscar;
    }
}