using IESPeniasNegras.Ecotrans.Nucleo.AccionesDonacion;
using Microsoft.AspNetCore.Mvc;

namespace IESPeniasNegras.Ecotrans.MVC.Controllers
{
    public class DonacionesController : Controller
    {
        public IActionResult Index()
        {
            var donacion = new AccionesDonacion();
            return View(donacion);
        }
    }
}
