using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Ciudades;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class CiudadesController : ControllerBase


    {


        //Interfaz
        public class Ciudad : IEquatable<Ciudad>
        {
            public string Id { get; set; }
            public string Name { get; set; }


            public bool Equals(Ciudad? ciudad)
            {
                return (this.Ciudad);
            }

        }



        




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

        //Polimorfismo
        public class Crear
        {
            [HttpPost]
            public ActionResult Crear(int Ciudad)
            {

                using (var accionesCiudad = new AccionesCiudades())
                {
                    return accionesCiudad.Crear();
                }


            }
        }

        public class Actualizar : Crear
        {
            [HttpPut]
            public ActionResult Actualizar(int Ciudad)

            {
                using (var accionesCiudad = new AccionesCiudades())
                {
                    return accionesCiudad.Editar();
                }


            }
        }

         





    }





}

    






    


