using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Direcciones;
using Microsoft.AspNetCore.Mvc;


namespace MVC.Controllers
{
    public class DireccionesController: Controller
    {

        public AccionesDirecciones AccionesDireccion { get; set; }

        public DireccionesController(AccionesDirecciones AccionesDireccion)
        {
            this.AccionesDireccion = AccionesDireccion;
        }




        //[Authorize(Roles =NombreRol....)]
        public IActionResult Guardar(EditarDireccionRequest editarDireccionesRequest)
        {

            var respuesta = AccionesDireccion.Editar(editarDireccionesRequest);
            return View("Detalles", respuesta);

        }
        //[Authorize(Roles =NombreRol....)]
        public IActionResult Crear(CrearDireccionRequest crear)
        {
            return View("FormularioCrear",crear);
        }
    }
}
