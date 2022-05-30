using System;
using System.ComponentModel.DataAnnotations;
namespace IESPeniasNegras.Ecotrans.Nucleo.Model;
public class Direccion
{
    public int Id {get; set;}
    public int ProvinciaId {get; set;}
    public Provincia Provincia {get; set;}
    public int CiudadId {get; set;}
    public Ciudad Ciudad {get; set;}
    public string Direccion1 {get; set;}
    public string? Direccion2 {get; set;}
    public int CodigoPostal {get; set;}
}

