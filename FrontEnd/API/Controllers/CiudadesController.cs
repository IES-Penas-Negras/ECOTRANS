using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Ciudades;
using IESPeniasNegras.Ecotrans.Nucleo.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;

namespace IESPeniasNegras.Ecotrans.API.Controllers
{
   [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CiudadesController : ControllerBase


    {
        [HttpGet("{id}")]
        //[Authorize(Roles =NombreRol....)]

        public IEnumerable<ListarCiudadRequest> Listar(string? buscar)

        {
            using (var accionesCiudad = new AccionesCiudades())
            {
                return accionesCiudad.Listar(ListarCiudadRequest);
            }

            if (Ciudad == null)
            {
                return (IEnumerable<ListarCiudadRequest>)NoContent();
            }
        }




        [HttpDelete("{id}")]
        //[Authorize(Roles =NombreRol....)]

        public ActionResult<CrearCiudadResponse> Eliminar([FromBody] AccionesCiudades accionesciudadPost)

        {

            using (var accionesCiudad = new AccionesCiudades())
            {

                return accionesCiudad.Borrar(BorrarCiudadRequest);

            }
            if (Ciudad == null)
            {
                return NoContent();
                return Ok();

            }




        }

        //Polimorfismo
        public class Crear
        {


            [HttpPost("{id}")]
            //[Authorize(Roles =NombreRol....)]
            public ActionResult<CrearCiudadResponse> Post([FromBody] AccionesCiudades accionesciudadPost)
            {

                using (var accionesCiudad = new AccionesCiudades())
                {
                    return accionesCiudad.Crear(CrearCiudadRequest);

                   //// if (!ModelState.IsValid)
                   // {
                   //     return BadHttpRequestException();
                   // }

                }


            }

            public class Actualizar : Crear
            {
                
                [HttpPut("{id}")]
                //[Authorize(Roles =NombreRol....)]
                public ActionResult<EditarCiudadResponse> Put([FromBody] AccionesCiudades accionesciudadPost)


                {
                   
                        
                    using (var accionesCiudad = new AccionesCiudades())
                    {
                        return accionesCiudad.Editar(EditarCiudadRequest);

                        if (accionesCiudad.Editar == null)
                        {
                            return NoContentResult();

                        }
                    }


                }

                private ActionResult<EditarCiudadResponse> NoContentResult()
                {
                    throw new NotImplementedException();
                }
            }






        }
    }

}







    






    


