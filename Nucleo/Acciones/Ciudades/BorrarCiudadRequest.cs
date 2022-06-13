using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Ciudades;

public class BorrarCiudadRequest
{
    public BorrarCiudadRequest(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
		
}
