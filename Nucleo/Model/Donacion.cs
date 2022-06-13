using System;
using System.ComponentModel.DataAnnotations;
    
namespace IESPeniasNegras.Ecotrans.Nucleo.Model;
    public class Donacion
    {

        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
    
        public int DireccionId { get; set; }
        public virtual Direccion? Direccion { get; set; }
        [Required]
        [StringLength(400)]
        public string Titulo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        [StringLength(3000)]
        public string Descripcion { get; set; }
        public IEnumerable<ObjetoDonacion> Objetos { get; set; } = new List<ObjetoDonacion>();




    }
        
   
