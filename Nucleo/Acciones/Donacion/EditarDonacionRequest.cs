using IESPeniasNegras.Ecotrans.Nucleo.Model;
using System;
using System.ComponentModel.DataAnnotations;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Donacion
{
    public class EditarDonacionRequest
    {
        public int IdEdicion{get; set;}
        [Required]
        [StringLength(400)]
        public string Titulo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        [StringLength(3000)]
        public string Descripcion { get; set; }
    }
}
