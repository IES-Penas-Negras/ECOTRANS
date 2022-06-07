using IESPeniasNegras.Ecotrans.Nucleo.Model;
using System;
using System.ComponentModel.DataAnnotations;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Ciudades;

public class EditarCiudadRequest
{
    public int IdEdicion{get; set;}
    [Required]
    [StringLength(300)]
    public string Nombre { get; set; }
  
}
