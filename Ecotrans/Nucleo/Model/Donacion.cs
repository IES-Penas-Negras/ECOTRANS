using System;



namespace Ecotrans
{
    public class Donacion
    {
       
       
      
        
        public string Usuario { get; set; }
       // public string Objeto { get; set; }
        //public string Dirección { get; set; }

        [Required]
        [StringLength(400)]
        public string Titulo { get; set; }
        public DateTime FechaInicio { get; set; }
       

        
        public DateTime? FechaFin { get; set; }
        [StringLength(3000)]
        public string Descripcion { get; set; }


    }
        
   
}