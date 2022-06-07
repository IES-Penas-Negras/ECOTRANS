using IESPeniasNegras.Ecotrans.Nucleo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Ciudades;

public class ListarCiudadResponse
{
    public ListarCiudadResponse(List<ListarCiudadElemento> ciudades)
    {
        Elementos = ciudades;
    }

    //TODO CREAR LA CLASE LISTAR CIUDAD ELEMENTO
    public List<ListarCiudadElemento> Elementos { get; set; }
    
}

 public class ListarCiudadElemento
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(300)]
        public string Nombre { get; set; }

    }
