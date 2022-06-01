using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Objeto;
using Microsoft.AspNetCore.Mvc;

namespace IESPeniasNegras.Ecotrans.MVC.Controllers;

public class ObjetosController : Controller
{

    public AccionesObjeto AccionesObjeto { get; set; }

    public ObjetosController(AccionesObjeto AccionesObjeto)
    {
        this.AccionesObjeto = AccionesObjeto;
    }

    public IActionResult Index(string? buscar = null)
    {
        var elementos = AccionesObjeto.Listar(new ListarObjetoRequest(buscar));
        return View(elementos);
    }
}
