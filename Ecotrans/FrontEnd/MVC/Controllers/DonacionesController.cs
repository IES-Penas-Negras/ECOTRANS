using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Donacion;
using Microsoft.AspNetCore.Mvc;

namespace IESPeniasNegras.Ecotrans.MVC.Controllers
{
    public class DonacionesController : Controller
    {
        public IActionResult Index()
        {
            var donacion = new AccionesDonacion();
            var elementos = donacion.Listar(new ListarDonacionResponse());
            return View(elementos);
        }
    }
}
