using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Usuarios;
using IESPeniasNegras.Ecotrans.Nucleo.Model;
using IESPeniasNegras.Ecotrans.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace IESPeniasNegras.Ecotrans.TestUnitarios;

    public class UsuariosTest
    {
        private readonly DonacionesTestContext contexto;
        private readonly AccionesUsuarios accionesUsuarios;

        public UsuariosTest()
        {
            contexto = new DonacionesTestContext();
            accionesUsuarios = new AccionesUsuarios(contexto);
        }

        
        [Fact]
        public void ListarUsuarioExistente()
        {
             /* var usuario = new Usuario()
            {
                UserName = "Andrea",
                Email = "prueba@dominio.es"            
            };
            */
            var usuario = new Usuario(); 
            usuario.UserName = "Andrea";
            usuario.Email = "prueba@dominio.es";
           
            contexto.Usuarios.Add(usuario);
            contexto.SaveChanges();
            
            var peticion = new ListarUsuarioRequest();
            var respuesta = accionesUsuarios.Listar(peticion);
            
            //Entonces (T h e n)
            Assert.NotEmpty(respuesta.Elementos);
        }
    } 
       