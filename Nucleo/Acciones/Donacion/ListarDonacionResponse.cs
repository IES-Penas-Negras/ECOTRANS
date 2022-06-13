using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Donacion
{
    public class ListarDonacionResponse
    {
        public ListarDonacionResponse(List<ListarDonacionElemento> donaciones)
        {
            Elementos = donaciones;
        }

        public List<ListarDonacionElemento> Elementos { get; set; }
    }

    public class ListarDonacionElemento
    {

        public string Usuario { get; set; }
        // public string Objeto { get; set; }
        //public string Dirección { get; set; }

        [Required]
        [StringLength(400)]
        public string Titulo { get; set; }
        public DateTime FechaInicio { get; set; }



        public DateTime? FechaFinal { get; set; }
        [StringLength(3000)]
        public string Descripcion { get; set; }


    }
}
    