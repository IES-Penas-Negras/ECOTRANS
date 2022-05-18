using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Objeto;
using Microsoft.AspNetCore.Mvc;

namespace IESPeniasNegras.Ecotrans.MVC.Controllers;

public class ObjetosController : Controller
{

    public IActionResult Index(string? buscar = null)
    {
        var objeto = new AccionesObjeto();
        var request = new ListarObjetoRequest()
        {
            Buscar = buscar
        };
       
        return View(objeto.Listar(request));  

    }
}
