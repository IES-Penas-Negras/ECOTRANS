using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Objetos;
using Microsoft.AspNetCore.Mvc;

namespace IESPeniasNegras.Ecotrans.MVC.Controllers;

public class ObjetosController : Controller
{

    public AccionesObjeto AccionesObjeto { get; set; }

    public ObjetosController(AccionesObjeto AccionesObjeto)
    {
        this.AccionesObjeto = AccionesObjeto;
    }


    public IActionResult Detalles(ListarObjetoElemento elemento)
    {
        return View(elemento);
    }

    public IActionResult Index(string? buscar = null)
    {
        var elementos = AccionesObjeto.Listar(new ListarObjetoRequest(buscar));
        return View(elementos);
    }

    public IActionResult Editar(ListarObjetoElemento editar)
    {
        return View("FormularioEdicion", editar);
    }

    public IActionResult Guardar(EditarObjetoRequest editarObjetoRequest)
    {
        
        var respuesta = AccionesObjeto.Editar (editarObjetoRequest);
        return View("Detalles", respuesta);
        
    }
}
