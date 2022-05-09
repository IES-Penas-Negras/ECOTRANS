using Microsoft.AspNetCore.Mvc;
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Objeto;

namespace IESPeniasNegras.Ecotrans.MVC.Controllers;

public class ObjetosController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
