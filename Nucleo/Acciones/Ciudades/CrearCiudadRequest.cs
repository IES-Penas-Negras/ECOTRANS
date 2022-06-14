using IESPeniasNegras.Ecotrans.Nucleo.Model;
using System;
using System.ComponentModel.DataAnnotations;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Ciudades;

    public class CrearCiudadRequest
    {
    public CrearCiudadRequest(string nombre)
    {
        Nombre = nombre;
    }

    [Required]
        [StringLength(300)]
        public string Nombre { get; set; }
        
    }

