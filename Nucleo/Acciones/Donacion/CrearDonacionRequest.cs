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
    
    public class Clases : DbContext
    {
       

        //Definicion de las clases requeridas para Donacion
        [Required]
        [StringLength(400)]
        public DbSet<Titulo> Titulos { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }

        //Definicion de la clase Descripcion que tiene un max de 3000 caracteres
        [StringLength(3000)]
        public string Descripcion { get; set; }



        //protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();


    }






    public class MenordeEdad : CrearDonacionRequest
    {
        private static int edadminima;

        public MenordeEdad(string Apellidos, string Nombre)
        { }

        static MenordeEdad() => edadminima = 16;

        //if(edadminima!=16)
        //{
        //    return(ErrorEventArgs);

        //    }

        
     }

   public class DonacionesDto
    {

        [Required]
        [StringLength(400)]
        public string Titulo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }


        


    }






}











    

