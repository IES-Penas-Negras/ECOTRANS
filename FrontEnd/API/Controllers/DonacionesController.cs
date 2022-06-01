using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using IESPeniasNegras;
using IESPeniasNegras.Ecotrans.Nucleo.BBDD;
using IESPeniasNegras.Ecotrans.Nucleo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Donaciones;

namespace IESPeniasNegras.Ecotrans.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DonacionesController : ControllerBase
    {
        private readonly AccionesDonacion accionesDonacion;
        public DonacionesController(AccionesDonacion accionesDonacion)
        {
            this.accionesDonacion = accionesDonacion;
        }


        [HttpGet("{id}")]
        public ListarDonacionResponse Get(string? buscar)
        {
            var listarRequest = new ListarDonacionRequest(buscar);
            return accionesDonacion.Listar(listarRequest);
        }

        [HttpPost]
        public ActionResult<CrearDonacionResponse> CrearDonacion ([FromBody] CrearDonacionRequest donacion)
        {
            if (!ModelState.IsValid)
                return BadRequest(donacion);
            var creacionDonacion = accionesDonacion.Crear(donacion);
            return Created(Request.Path.Value + creacionDonacion.Id, creacionDonacion);
        }
       

        [HttpPut("{id}")]
        public ActionResult<EditarDonacionResponse> EditarDonacion(int id, [FromBody] EditarDonacionRequest donacion)
        {
            if (!ModelState.IsValid)
                return BadRequest(donacion);
            var editarDonacion = accionesDonacion.Editar(donacion);
            return Ok(donacion);
        }

        [HttpDelete("{id}")]
        public ActionResult BorrarDonacion(int id)
        {
            var donacion = new BorrarDonacionRequest(id);
            accionesDonacion.Borrar(donacion);
            return Ok();
        }
    }
}
