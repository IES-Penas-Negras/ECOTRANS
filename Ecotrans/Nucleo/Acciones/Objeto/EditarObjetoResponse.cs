using System;
using System.ComponentModel.DataAnnotations;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Objeto
{
    public class EditarObjetoResponse
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
}
