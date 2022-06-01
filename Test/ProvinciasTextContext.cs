using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Provincia;
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Provincias;
using IESPeniasNegras.Ecotrans.Nucleo.Model;
using IESPeniasNegras.Ecotrans.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace IESPeniasNegras.Ecotrans.TestUnitarios;

public class ProvinciasTextContext
{
    private readonly DonacionesTestContext contexto;
    private readonly AccionesProvincias accionesProvincias;
    public ProvinciasTest()
    {
        contexto = new DonacionesTestContext();
        accionesProvincias = new AccionesProvincias(contexto);
    }


    //interface Provincias
    //{
    //    void AccionesProvincias();
    //}

    //class ImplementationClass : Provincias
    //{

    //    void Provincias.AccionesProvincias()
    //    {

    //    }

    //    static void Main()
    //    {

    //        Provincias obj = new AccionesProvincias();


    //        obj.AccionesProvincias();
    //    }

    //    public void AccionesProvincias()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}










    [Fact]



    public void Debe_Listar_Una_Provincia()
    {
        var Provincia = new Provincia()
        {
            Nombre = "Ciudad Real"
        };

        contexto.SaveChanges();
        //When
        var peticion = new ListarProvinciaRequest();
        var respuesta = accionesProvincias.Listar(peticion);
        //Then 
        Assert.NotEmpty(respuesta);



    }


    public void NO_Debe_Listar_Una_Provincia_Existente_Cuando_No_Esta_En_La_Busqueda(object accionesProvincia)
    {
        // Given
        var Provincia = new Provincia()
        {
            Nombre = "Toledo"

        };

        var provincia = new Provincia()
        {
           
        };
        contexto.Provincias.Add(provincia);
        contexto.SaveChanges();
        // When
        var peticion = new ListarProvinciaRequest()
        {
           Nombre = "Toledo"
        };
        var respuesta = accionesProvincia.Listar(peticion);
        // Then
        Assert.Empty(respuesta.Elementos);
    }




}

