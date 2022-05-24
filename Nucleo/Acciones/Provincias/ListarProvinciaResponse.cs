using IESPeniasNegras.Ecotrans.Nucleo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Provincia;

public class ListarProvinciaResponse
{
	public List<ListarProvinciaElemento> Elementos { get; set; }
	[Required]
	[StringLength(300)]
	public string NombreProvincia { get; set; }
	public int TipoObjetoId { get; set; }
}
