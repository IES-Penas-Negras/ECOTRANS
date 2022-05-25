using IESPeniasNegras.Ecotrans.Nucleo.Model;
using System;
using System.ComponentModel.DataAnnotations;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Provincia;

public class CrearProvinciaResponse
{
	[Required]
	[StringLength(300)]
	public string NombreProvincia { get; set; }
	public int TipoObjetoId { get; set; }
}	
