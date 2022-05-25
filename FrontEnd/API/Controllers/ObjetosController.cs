
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IESPeniasNegras;
using IESPeniasNegras.Ecotrans.Nucleo.BBDD;
using IESPeniasNegras.Ecotrans.Nucleo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Objeto;

//Si no detecta las referencias al Nucleo hay que ir a /FrontEnd/API/Dependencias/Proyectos, hacer click derecho sobre 
//la carpeta de proyectos y hacer referencia a lo que no detecte (por lo general el Nucleo)

namespace API.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ObjetosController : ControllerBase
    {
        private readonly AccionesObjeto accionesObjeto;
        public ObjetosController(AccionesObjeto accionesObjeto)
        {
            this.accionesObjeto = accionesObjeto;
        }
       
        [HttpGet]
        public ListarObjetoResponse Get(string? buscar)
        {
            var listarRequest = new ListarObjetoRequest();
            return accionesObjeto.Listar(listarRequest);

        }

        //[HttpGet("{id}")]
        //public ActionResult<Objeto>Get(int id)
        //{
        //    var objeto = accionesObjeto.Crear.ProjectTo<Objeto>(mapper.ConfigurationProvider).SingleOrDefault(c => c.Id == id);
        //    if (objeto == null)
        //    {
        //        return NotFound();
        //    }
            
        //    return Ok(objeto);
        //}
        
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
