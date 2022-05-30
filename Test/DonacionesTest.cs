using Xunit;
using System;
using System.Linq;
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Objeto;
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Donacion;
using IESPeniasNegras.Ecotrans.Nucleo.Model;
using IESPeniasNegras.Ecotrans.Test;

public class DonacionesTest
{
    private readonly DonacionesTestContext contexto;
    private readonly AccionesDonacion accionesDonacion;
    public DonacionesTest()
    {
        contexto = new DonacionesTestContext();         
        accionesDonacion = new AccionesDonacion(); 
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
        var crearDonacion = new CrearDonacionRequest()
        {
            Titulo = donacion.Titulo,
            FechaInicio = donacion.FechaInicio,
            FechaFin = donacion.FechaFin,
            Descripcion = donacion.Descripcion
        };
        var peticion = new ListarDonacionRequest();
        var respuestaDonacion = new AccionesDonacion.Crear(peticion);
        
        //Then
        Assert.Equal(respuestaDonacion.Titulo, donacion.Titulo);
        Assert.Equal(respuestaDonacion.FechaInicio, donacion.FechaInicio);
        Assert.Equal(respuestaDonacion.FechaFin , donacion.FechaFin);
        Assert.Equal(respuestaDonacion.Descripcion, donacion.Descripcion);
    }
    [Fact]
    public void Debe_Listar_Una_Donacion_Existente()
    {
        //Given
        var donacion = new Donacion()
        {
            Titulo = "",
            /*FechaInicio = ,
            FechaFin = ,*/
             Descripcion = "Silla en muy buen estado, fabricada en madera de roble, perfecta para poner en el salon"
        };
        contexto.Donaciones.Add(donacion);
        contexto.SaveChanges();
        //When
        var peticion = new ListarDonacionRequest();
        var respuesta = accionesDonacion.Listar(peticion);
        //Then
        Assert.NotEmpty(respuesta.Elementos);
    }
        
    [Fact]
    public void Debe_Editar_Una_Donacion_Existente()
    {
        //Given
        var editarDonacion = new Donacion()
        {
            Titulo = "",
            /*FechaInicio = "25/05/2022",
            FechaFin = "30/06/2022",*/
            Descripcion = "Silla en muy buen estado, fabricada en madera de roble, perfecta para poner en el salon"
        };
        
        //When
        var peticion = new ListarDonacionRequest();
        var respuestaDonacion = AccionesDonacion.Listar(peticion);
        //Then
        Assert.NotEmpty(respuestaDonacion.Elementos);
    }
    [Fact]
    public void No_Debe_Listar_Una_Donacion_Existente_Cuando_No_Esta_En_La_Busqueda()
    {
        //Given
        var donacion = new Donacion()
        {
            Titulo = "",
            /*FechaInicio = "25/05/2022",
            FechaFin = "30/06/2022",*/
            Descripcion = "Silla en muy buen estado, fabricada en madera de roble, perfecta para poner en el salon"
        };
        contexto.Donaciones.Add(donacion);
        contexto.SaveChanges();
        //When
        
        var peticion= new ListarObjetoRequest()
        {
            Buscar= "Silla"
        };
        var respuesta= AccionesDonacion.Listar(peticion);
        // Then
        Assert.Empty(respuesta.Elementos);
        
    }
    public void Debe_Editar_Una_Donacion_Existente_Titulo()
    {
        var donacion = new Donacion()
        {
            Titulo = "",
            /*FechaInicio = "25/05/2022",
            FechaFin = "30/06/2022",*/
            Descripcion = "Silla en muy buen estado, fabricada en madera de roble, perfecta para poner en el salon"
        };
        contexto.Donaciones.Add(donacion);
        contexto.SaveChanges();
        //When
        var peticion = new EditarDonacionRequest()
        {
            IdEdicion = donacion.Id,
            Titulo = donacion.Titulo,
            FechaInicio = donacion.FechaInicio,
            FechaFin = donacion.FechaFin,
            Descripcion = donacion.Descripcion
        };
        var respuesta = accionesDonacion.Editar(peticion);
        //Then
        Assert.Equal(respuesta.Id, donacion.Id);
        Assert.Equal(respuesta.Titulo, donacion.Titulo);
        Assert.Equal(respuesta.FechaInicio, donacion.FechaInicio);
        Assert.Equal(respuesta.FechaFin, donacion.FechaFin);
        Assert.Equal(respuesta.Descripcion, donacion.Descripcion);
    }
    [Fact]
    public void Debe_Borrar_Una_Donacion_Existente()
    {
        //Given
        var donacion = new Donacion()
        {
            Titulo = "",
            FechaInicio = DateTime("25/05/2022"),
            FechaFin = DateTime("30/06/200"),

            Descripcion = "Silla en muy buen estado, fabricada en madera de roble, perfecta para poner en el salon"
        };
        DateTime DateTime(string v) => throw new NotImplementedException();
        
        contexto.Donaciones.Add(donacion);
        contexto.SaveChanges();
        //When
        var peticion = new BorrarDonacionRequest()
        {
            Id = donacion.Id
        };
        accionesDonacion.Borrar(peticion);
        //Then
        var donacionDB = contexto.Donaciones.SingleOrDefault(d => d.Id == donacion.Id);
            Assert.Null(donacionDB);
    }

}

