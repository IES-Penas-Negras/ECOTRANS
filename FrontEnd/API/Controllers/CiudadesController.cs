using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Ciudades;
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Direcciones;
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
        private readonly AccionesCiudades accionesCiudad;
        public CiudadesController(AccionesCiudades accionesCiudad)
        {
            this.accionesCiudad = accionesCiudad;
        }


        [HttpGet()]
        //[Authorize(Roles =NombreRol....)]

        //public IEnumerable<ListarCiudadResponse> Listar(string? buscar)

        //{
        //    using (var accionesCiudad = new AccionesCiudades())
        //    {
        //        return accionesCiudad.Listar(ListarCiudadResponse);
        //    }

        //    if (Ciudad == null)
        //    {
        //        return (IEnumerable<ListarCiudadResponse>)NoContent();
        //    }
        //}


        [HttpDelete("{id}")]
        //[Authorize(Roles =NombreRol....)]


        [HttpDelete("{id}")]
        public ActionResult BorrarCiudad(int id)
        {
            var ciudad = new BorrarCiudadRequest(id);
            accionesCiudad.Borrar(ciudad);
            return Ok();
        }

        [HttpPost("{id}")]
        //[Authorize(Roles =NombreRol....)]
        public ActionResult<CrearCiudadResponse> CrearCiudad([FromBody] CrearCiudadRequest ciudad)
        {
            if (!ModelState.IsValid)
                return BadRequest(ciudad);
            var creacionCiudad = accionesCiudad.Crear(ciudad);
            return Created(Request.Path.Value + creacionCiudad.Id, creacionCiudad);
        }


        [HttpPut("{id}")]
        //[Authorize(Roles =NombreRol....)]
        public ActionResult<EditarCiudadResponse> Put([FromBody] AccionesCiudades accionesciudadPut, EditarCiudadRequest editarCiudadRequest)

        {
            using (var accionesCiudad = new AccionesCiudades())
            {
                var ciudadEditada = accionesCiudad.Editar(editarCiudadRequest);

                if (ciudadEditada == null)
                {
                    return BadRequest();

                }
                else
                {
                    return Ok(ciudadEditada);
                }
            }
        }

    }
}
    









    






    


