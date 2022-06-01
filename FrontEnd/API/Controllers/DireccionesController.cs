using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Direcciones;

namespace IESPeniasNegras.Ecotrans.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DireccionesController : ControllerBase
    {
        private readonly AccionesDirecciones accionesDirecciones;
        public DireccionesController(AccionesDirecciones accionesDirecciones)
        {
            this.accionesDirecciones = accionesDirecciones;
        }


        [HttpGet("{id}")]
        public ListarDireccionResponse Get(string? buscar)
        {
            var listarRequest = new ListarDireccionRequest(buscar);
            return accionesDirecciones.Listar(listarRequest);
        }

       

        [HttpPost]
        public ActionResult<CrearDireccionResponse> Crear([FromBody] CrearDireccionRequest direccion)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var direccionCreada = accionesDirecciones.Crear(direccion);
             return Created(Request.Path.Value + direccionCreada.Id, direccionCreada);
        }


        [HttpPut("{id}")]
        public ActionResult<EditarDireccionResponse> Editar (int id, [FromBody] EditarDireccionRequest direccion)
        {
             if (!ModelState.IsValid) 
                return BadRequest();
            var direccionEditada = accionesDirecciones.Editar(direccion);
            return Ok(direccionEditada);
        }

        [HttpDelete("{id}")]
        public ActionResult Borrar(int id)
        {
            var direccion = new BorrarDireccionRequest(id);
            accionesDirecciones.Borrar(direccion);
            return Ok();
        }
    }
}
