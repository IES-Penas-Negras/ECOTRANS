using Xunit;
using System.Linq;
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Objeto;
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Donacion;
using IESPeniasNegras.Ecotrans.Nucleo.BBDD;
using IESPeniasNegras.Ecotrans.Nucleo.Model;
using IESPeniasNegras.Ecotrans;

public class ObjetosTest
{
    private readonly DonacionesTestContext contexto;
    private readonly AccionesObjeto accionesObjeto;
    public ObjetosTest()
    {
        contexto = new DonacionesTestContext();         
        accionesObjeto = new AccionesObjeto(contexto); 
    }
    [Fact]
    public void Debe_Crear_Una_Donacion()
    {
        //Given
        var donacion = new Donacion()
        {
            Nombre = "Silla",
            FechaInicio = "25/05/2022",
            FechaFin = "30/06/2022",
            Descripcion = "Silla en muy buen estado, fabricada en madera de roble, perfecta para poner en el salon"
        };
        //When
        var peticionDonacion = new CrearDonacionRequest()
        {
            Nombre = donacion.Nombre,
            FechaInicio = donacion.FechaInicio,
            FechaFin = donacion.FechaFin,
            Descripcion = donacion.Descripcion
        };
    }
}

