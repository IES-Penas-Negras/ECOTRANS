using System.Linq;
using IESPeniasNegras.Ecotrans.Nucleo.Acciones;
using IESPeniasNegras.Ecotrans.Nucleo.Model;
using Xunit;

namespace IESPeniasNegras.Ecotrans.Test;
public class DireccionesTest
{
    private readonly DonacionesTestContext contexto;
    private readonly AccionesDireccion accionesDireccion;

    public AccionesTest()
    {
        contexto = new DonacionesTestContext();
        accionesDireccion = new AccionesDireccion(contexto);
    }
}

