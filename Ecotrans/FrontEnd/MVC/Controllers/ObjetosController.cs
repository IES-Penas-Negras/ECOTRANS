using IESPeniasNegras.Ecotrans.Nucleo.AccionesObjeto;
using Microsoft.AspNetCore.Mvc;

namespace IESPeniasNegras.Ecotrans.MVC.Controllers;

public class ObjetosController : Controller
{
    public IActionResult Index()
    {
        var objeto = new AccionesObjeto()
        return View(objeto);  
    }
}
