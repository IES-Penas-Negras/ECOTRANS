using Xunit;
using System;
using System.Linq;
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Objeto;
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Donacion;
using IESPeniasNegras.Ecotrans.Nucleo.Model;
using IESPeniasNegras.Ecotrans.Test;
x

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
    public void Debe_Crear_Una_Donacion(AccionesDonacion accionesDonacion)
    {
        //Given
        var donacion = new Donacion()
        {
            Titulo = "",
            /*FechaInicio = "25/05/2022",
            FechaFin = "30/06/2022",*/
            Descripcion = "Silla en muy buen estado, fabricada en madera de roble, perfecta para poner en el salon"
        };
        //When
        var peticionDonacion = new CrearDonacionRequest()
        {
            Titulo = donacion.Titulo,
            FechaInicio = donacion.FechaInicio,
            FechaFin = donacion.FechaFin,
            Descripcion = donacion.Descripcion
        };
        var respuestaDonacion = accionesDonacion.Crear(peticionDonacion);
        //Then
        Assert.Equal(respuestaDonacion.Titulo, donacion.Titulo);
        Assert.Equal(respuestaDonacion.FechaInicio, donacion.FechaInicio);
        Assert.Equal(respuestaDonacion.FechaFin , donacion.FechaFin);
        Assert.Equal(respuestaDonacion.Descripcion, donacion.Descripcion);
    }
    [Fact]
    public void Debe_Editar_Una_Donacion_Existente()
    {
        //Given
        var donacion = new Donacion()
        {
            
        };
    }

}

