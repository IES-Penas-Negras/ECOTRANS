using IESPeniasNegras.Ecotrans.Nucleo.Model;
using System;
using System.ComponentModel.DataAnnotations;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Ciudades;

public class EditarCiudadRequest
{
    public EditarCiudadRequest(string nombre, int idEdicion )
    {
       Nombre = nombre;
       IdEdicion = idEdicion;   
    }

    public int IdEdicion{get; set;}
    [Required]
    [StringLength(300)]
    public string Nombre { get; set; }
  
}
