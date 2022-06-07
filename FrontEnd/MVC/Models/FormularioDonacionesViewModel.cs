using MVC.Models;
using System.Collections.Generic;
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Donacion;
using IESPeniasNegras.Ecotrans.Nucleo.Model;

namespace IESPeniasNegras.Ecotrans.MVC.Models
{
    public class FormularioDonacionesViewModel
    {
        public Donacion donacion {get; set;}

        public string Titulo => this.donacion.Id == 0 ? "Nueva Donación" : "Editar Donación";
    }
}