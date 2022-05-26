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
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Donacion;

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
            var listarRequest = new ListarDonacionRequest();
            return accionesDonacion.Listar(listarRequest);
        }

       

        [HttpPost]
        public ActionResult<CrearDonacionResponse> Post([FromBody] AccionesDonacion accionesDonacionPost)
        {
            return accionesDonacion.Post(accionesDonacionPost);
        }


        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
