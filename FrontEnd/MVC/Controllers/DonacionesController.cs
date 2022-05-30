using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Donacion;
using Microsoft.AspNetCore.Mvc;

namespace IESPeniasNegras.Ecotrans.MVC.Controllers
{
    public class DonacionesController : Controller
    {
        public AccionesDonacion AccionesDonacion { get; set; }

        public DonacionesController(AccionesDonacion AccionesDonacion)
        {
            this.AccionesDonacion = AccionesDonacion;
        }

        public IActionResult Index(string? buscar = null)
        {
            var elementos = AccionesDonacion.Listar(new ListarDonacionRequest(buscar));
            return View(elementos);
        }
    }
}
