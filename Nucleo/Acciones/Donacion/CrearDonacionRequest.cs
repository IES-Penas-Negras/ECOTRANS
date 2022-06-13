using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Donacion;


public class CrearDonacionRequest
{
    
        //Definicion de las clases requeridas para Donacion
        [Required]
        [StringLength(400)]
        public string Titulo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }

        //Definicion de la clase Descripcion que tiene un max de 3000 caracteres
        [StringLength(3000)]
        public string Descripcion { get; set; }

         public int UsuarioId { get; set; }
    
        public int DireccionId { get; set; }
        public IEnumerable <int> Objetos { get; set; } = new List<int>();
        
}











    

