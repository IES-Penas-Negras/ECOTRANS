using IESPeniasNegras.Ecotrans.MVC.Models;
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Donacion;
using Microsoft.AspNetCore.Mvc;
using IESPeniasNegras.Ecotrans.Nucleo.BBDD;
using Microsoft.EntityFrameworkCore;

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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Guardar (DonacionesController donacion)
        {
            return RedirectToAction ("Index" , "Donaciones");
        }
        [HttpPost]
        public IActionResult Editar(EditarDonacionRequest editarDonacionRequest)
        {
            return RedirectToAction ("FormularioDonaciones","Donaciones");
        }
    }
}

