using System.Linq;
using System.ComponentModel.DataAnnotations;
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Direcciones;
using IESPeniasNegras.Ecotrans.Nucleo.Model;
using Xunit;

namespace IESPeniasNegras.Ecotrans.Test;
public class DireccionesTests
{
    private readonly DonacionesTestContext contexto;
    private readonly AccionesDirecciones accionesDirecciones;

    public DireccionesTests()
    {
        contexto = new DonacionesTestContext();
        accionesDirecciones = new AccionesDirecciones(contexto);
    }
    [Fact]
    public void Test_De_Creacion_De_direccion()
    {
        //dado
        var provincia = new Provincia();
        {
   
        };
        var ciudad = new Ciudad();
        { 

        };
        var direccion = new Direccion();
        {

        };
    }
}


