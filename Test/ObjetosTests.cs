using System.Linq;
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Objeto;
using IESPeniasNegras.Ecotrans.Nucleo.Model;
using Xunit;

namespace IESPeniasNegras.Ecotrans.Test;

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
    public void Debe_Crear_Un_Objeto()
    {
        // Given
        var tipoObjeto= new TipoObjeto()
        {
            Nombre= "Mueble"
        };
        var objeto = new Objeto()
        {
            Nombre= "Mesa",
            TipoObjeto= tipoObjeto,
            Estado= Estado.SemiNuevo,
            Altura= 120,
            Anchura=100,
            Profundidad=60,
            Peso=2
        };

        // When
        var peticion= new CrearObjetoRequest()
        {
            Nombre= objeto.Nombre,
            TipoObjetoId= objeto.TipoObjetoId,
            Estado= objeto.Estado,
            Altura= objeto.Altura,
            Anchura= objeto.Anchura,
            Profundidad= objeto.Profundidad,
            Peso= objeto.Peso
        };
        var respuesta= accionesObjeto.Crear(peticion);
        // Then
        Assert.True(respuesta.Id>0);
        Assert.Equal(respuesta.Nombre, objeto.Nombre);
        Assert.Equal(respuesta.TipoObjetoId, objeto.TipoObjetoId);
        Assert.Equal(respuesta.Estado, objeto.Estado);
        Assert.Equal(respuesta.Altura, objeto.Altura);
        Assert.Equal(respuesta.Anchura, objeto.Anchura);
        Assert.Equal(respuesta.Profundidad, objeto.Profundidad);
        Assert.Equal(respuesta.Peso, objeto.Peso);
    }

    [Fact]
    public void Debe_Listar_Un_Objeto_Existente()
    {
        // Given
        var tipoObjeto= new TipoObjeto()
        {
            Nombre= "Mueble"
        };

        var objeto = new Objeto()
        {
            Nombre= "Mesa",
            TipoObjeto= tipoObjeto,
            Estado= Estado.SemiNuevo,
            Altura= 120,
            Anchura=100,
            Profundidad=60,
            Peso=2
        };
        contexto.Objetos.Add(objeto);
        contexto.SaveChanges();
        // When
        var peticion= new ListarObjetoRequest();
        var respuesta= accionesObjeto.Listar(peticion);
        // Then
        Assert.NotEmpty(respuesta.Elementos);
    }

    [Fact]
    public void NO_Debe_Listar_Un_Objeto_Existente_Cuando_No_Esta_En_La_Busqueda()
    {
        // Given
        var tipoObjeto= new TipoObjeto()
        {
            Nombre= "Mueble"
        };

        var objeto = new Objeto()
        {
            Nombre= "Mesa",
            TipoObjeto= tipoObjeto,
            Estado= Estado.SemiNuevo,
            Altura= 120,
            Anchura=100,
            Profundidad=60,
            Peso=2
        };
        contexto.Objetos.Add(objeto);
        contexto.SaveChanges();
        // When
        var peticion= new ListarObjetoRequest()
        {
            Buscar= "Silla"
        };
        var respuesta= accionesObjeto.Listar(peticion);
        // Then
        Assert.Empty(respuesta.Elementos);
    }

    [Fact]
    public void Debe_Listar_Filtrando_Dos_Objetos()
    {
        // Given
        var tipoObjeto= new TipoObjeto()
        {
            Nombre= "Mueble"
        };

        var primerobjeto = new Objeto()
        {
            Nombre= "Mesa",
            TipoObjeto= tipoObjeto,
            Estado= Estado.SemiNuevo,
            Altura= 120,
            Anchura=100,
            Profundidad=60,
            Peso=2
        };

        var segundoobjeto = new Objeto()
        {
            Nombre= "Silla",
            TipoObjeto= tipoObjeto,
            Estado= Estado.SemiNuevo,
            Altura= 120,
            Anchura=100,
            Profundidad=60,
            Peso=2
        };
        contexto.Objetos.Add(primerobjeto);
        contexto.SaveChanges();
        // When
        var peticion= new ListarObjetoRequest()
        {
            Buscar= "Silla"
        };
        var respuesta= accionesObjeto.Listar(peticion);
        // Then
        Assert.NotEmpty(respuesta.Elementos);
        Assert.True(respuesta.Elementos.Select(e => e.Nombre).Contains(segundoobjeto.Nombre));
    }

    [Fact]
    public void Debe_Editar_Un_Objeto_Existente_Nombre()
    {
        // Given
         var tipoObjeto= new TipoObjeto()
        {
            Nombre= "Mueble"
        };
        var objeto = new Objeto()
        {
            Nombre= "Mesa",
            TipoObjeto= tipoObjeto,
            Estado= Estado.SemiNuevo,
            Altura= 120,
            Anchura=100,
            Profundidad=60,
            Peso=2
        };
        contexto.Objetos.Add(objeto);
        contexto.SaveChanges();
        // When
        var peticion= new EditarObjetoRequest()
        {
            IdEdicion= objeto.Id,
            Nombre= "Silla",
            Estado= objeto.Estado,
            Altura= objeto.Altura,
            Anchura= objeto.Anchura,
            Profundidad= objeto.Profundidad,
            Peso= objeto.Peso
        };
        var respuesta= accionesObjeto.Editar(peticion);
        // Then
         Assert.Equal(respuesta.Id, objeto.Id);
         Assert.Equal(respuesta.Estado, objeto.Estado);
         Assert.Equal(respuesta.Altura, objeto.Altura);
         Assert.Equal(respuesta.Anchura, objeto.Anchura);
         Assert.Equal(respuesta.Profundidad, objeto.Profundidad);
         Assert.Equal(respuesta.Peso, objeto.Peso);
    }

    [Fact]
    public void Debe_Borrar_Un_Objeto_Existente()
    {
        // Given
         var tipoObjeto= new TipoObjeto()
        {
            Nombre= "Mueble"
        };
        var objeto = new Objeto()
        {
            Nombre= "Mesa",
            TipoObjeto= tipoObjeto,
            Estado= Estado.SemiNuevo,
            Altura= 120,
            Anchura=100,
            Profundidad=60,
            Peso=2
        };
        contexto.Objetos.Add(objeto);
        contexto.SaveChanges();
        // When
        var peticion = new BorrarObjetoRequest(objeto.Id);
         accionesObjeto.Borrar(peticion);
        // Then
        var objetoDB= contexto.Objetos.SingleOrDefault(o => o.Id==objeto.Id);
         Assert.Null(objetoDB);
    }
}