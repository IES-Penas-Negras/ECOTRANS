
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Usuarios;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers;


    public class UsuariosController : Controller
    {
        public AccionesUsuarios accionesUsuarios { get; set; }

        public IActionResult Index()
        {
            return View();
        
        }
    }
    


