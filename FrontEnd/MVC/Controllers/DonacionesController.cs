using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Donacion;
using Microsoft.AspNetCore.Mvc;

namespace IESPeniasNegras.Ecotrans.MVC.Controllers
{
    public class DonacionesController : Controller
    {

        private readonly AccionesDonacion accionesDonacion;

        public DonacionesController(AccionesDonacion accionesDonacion)
        {
            this.accionesDonacion = accionesDonacion;
        }

        public IActionResult Index(string? buscar = null)
        {
            var elementos = accionesDonacion.Listar(new ListarDonacionRequest(buscar));
            return View(elementos);
        }
    }
}
