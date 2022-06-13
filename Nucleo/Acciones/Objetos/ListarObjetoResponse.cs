using IESPeniasNegras.Ecotrans.Nucleo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Objetos;
public class ListarObjetoResponse
{
    public ListarObjetoResponse(List<ListarObjetoElemento> elementos)
    {
		Elementos = elementos;
    }

    public List<ListarObjetoElemento> Elementos {get; set;}

}

public class ListarObjetoElemento
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
	public string GetDimensiones()
	{
		return Altura.ToString() + Anchura.ToString() + Profundidad.ToString();
	}
	
}
