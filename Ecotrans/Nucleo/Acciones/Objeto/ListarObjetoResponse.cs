using IESPeniasNegras.Ecotrans.Nucleo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Objeto;
public class ListarObjetoResponse
{
    public List<ListaObjetoElemento> Elementos {get; set;}

}

public class ListaObjetoElemento
{
	public int Id { get; set; }
    [Required]
	[StringLength(300)]
	public string Nombre { get; set; }
	public int TipoObjetoId { get; set; }
	public Estado Estado { get; set; }
	public decimal Altura { get; set; }
	public decimal Anchura { get; set; }
	public decimal Profundidad { get; set; }
	public decimal Peso { get; set; }
}
