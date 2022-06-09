
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Usuarios;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers;


    public class UsuariosController : Controller
    {
        public AccionesUsuarios accionesUsuarios { get; set; }

         public IActionResult Index(string? buscar = null)
        {
            var elementos = accionesUsuarios.Listar(new ListarUsuarioRequest(buscar));
            return View(elementos);
        }
    }


