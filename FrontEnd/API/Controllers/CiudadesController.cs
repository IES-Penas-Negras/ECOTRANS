using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Ciudades;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CiudadésController : ControllerBase


    {
        public IEnumerable<object> Listar()

        {
            using (var accionesCiudad = new AccionesCiudades())
            {
                return accionesCiudad.Listar();
            }

        }

        [HttpDelete]
        public ActionResult Eliminar(int Ciudad)
        {
            using (var accionesCiudad = new AccionesCiudades())
            {
                return accionesCiudad.Borrar();
            }
                
        }

        [HttpPost]
        public ActionResult Crear(int Ciudad)
        {

            using (var accionesCiudad = new AccionesCiudades())
            {
                return accionesCiudad.Crear();
            }
               
            
        }
        [HttpPut]
        public ActionResult  Actualizar(int Ciudad)

        {
            using (var accionesCiudad = new AccionesCiudades())
            {
                return accionesCiudad.Editar();
            }
                
           
        }





    }



   





}




    


