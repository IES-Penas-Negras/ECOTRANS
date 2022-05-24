using IESPeniasNegras.Ecotrans.Nucleo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Ciudad;

public class ListarCiudadResponse
{
	public List<ListarCiudadElemento> Elementos { get; set; }
    [Required]
    [StringLength(300)]
    public string NombreCiudad { get; set; }
    public int TipoObjetoId { get; set; }
    public int CP { get; set; }
}
