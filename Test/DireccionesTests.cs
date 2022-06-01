using System.Linq;
using System.ComponentModel.DataAnnotations;
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Direcciones;
using IESPeniasNegras.Ecotrans.Nucleo.Acciones;
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
    public void Test_De_Creacion_De_Direccion()
    {
        //Dado ( G i v e n ) 
        var provincia = new Provincia()
        {
           Nombre = "Zamora"
        };
        var ciudad = new Ciudad()
        { 
            Nombre = "ZamoraCity"
        };
        var direccion = new Direccion()
        {
            Provincia = provincia,
            Ciudad = ciudad,
            Direccion1 =  "CalleFalsa123",
            Direccion2 = "CalleVerdadera456",
            CodigoPostal = 45400,
        };
        //Cuando ( W h e n ) 
        var peticion = new CrearDireccionRequest()
        {
            ProvinciaId = direccion.ProvinciaId,
            CiudadId = direccion.CiudadId,
            Direccion1 = direccion.Direccion1,
            Direccion2 = direccion.Direccion2,
            CodigoPostal = direccion.CodigoPostal,
        };
        var respuesta = accionesDirecciones.Crear(peticion);
        //Entonces (T h e n)
        Assert.True(respuesta.Id > 0);
        Assert.Equal(respuesta.ProvinciaId, direccion.ProvinciaId);
        Assert.Equal(respuesta.CiudadId, direccion.CiudadId);
        Assert.Equal(respuesta.Direccion1, direccion.Direccion1);
        Assert.Equal(respuesta.Direccion2, direccion.Direccion2);
        Assert.Equal(respuesta.CodigoPostal, direccion.CodigoPostal);
    }
}


