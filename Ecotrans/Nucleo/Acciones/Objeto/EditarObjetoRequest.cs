using System;
using System.ComponentModel.DataAnnotations;

namespace IESPeñasNegras.Ecotrans.Nucleo.Acciones.Objeto
{
    public class EditarObjetoRequest
    {
        public int Id_Edicion { get; set; }
		[Required]
		[StringLength(300)]
		public string Nombre { get; set; }
		public TipoObjeto TipoObjeto { get; set; }
		public int TipoObjetoId { get; set; }
		public Estado Estado { get; set; }
		public decimal Altura { get; set; }
		public decimal Anchura { get; set; }
		public decimal Profundidad { get; set; }
		public decimal Peso { get; set; }
	}
}
