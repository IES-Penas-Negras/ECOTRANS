using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Objetos;
using Microsoft.AspNetCore.Mvc;

namespace IESPeniasNegras.Ecotrans.MVC.Controllers;

public class ObjetosController : Controller
{

    private readonly AccionesObjeto accionesObjeto;

    public ObjetosController(AccionesObjeto accionesObjeto)
    {
        this.accionesObjeto = accionesObjeto;
    }


    public IActionResult Detalles(ListarObjetoElemento elemento)
    {
        return View(elemento);
    }

    public IActionResult Index(string? buscar = null)
    {
        var elementos = accionesObjeto.Listar(new ListarObjetoRequest(buscar));
        return View(elementos);
    }

    public IActionResult Editar(ListarObjetoElemento editar)
    {
        return View("FormularioEdicion", editar);
    }

    public IActionResult Guardar(EditarObjetoRequest editarObjetoRequest)
    {
        
        var respuesta = accionesObjeto.Editar (editarObjetoRequest);
        return View("Detalles", respuesta);
        
    }
}
