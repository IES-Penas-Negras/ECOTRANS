using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace IESPeñasNegras.Ecotrans.Nucleo.Donacion.CrearDonacionRequest;


    public class CrearDonacionRequest
    {
      [Required]
      [StringLength(400)]
      public string Titulo { get; set; }
      public DateTime FechaInicio { get; set; }
      public DateTime? FechaFin { get; set; }
      [StringLength(3000)]
      public string Descripcion { get; set; }





    }

