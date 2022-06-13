using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Usuarios;
using IESPeniasNegras.Ecotrans.Nucleo.Model;
using IESPeniasNegras.Ecotrans.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace IESPeniasNegras.Ecotrans.TestUnitarios
{
    public class UsuariosTest
    {
        private readonly UsuariosTestContext contexto;
        private readonly AccionesUsuarios accionesUsuarios;

        public UsuariosTest()
        {
            contexto = new UsuariosTestContext();
            accionesUsuarios = new AccionesUsuarios(contexto);
        }
        [Fact]
        public void TestDeUsuarios()
        { 
            var nombre = new Nombre()
            {
                Nombre = "Andrea"
            };
            var apellidos = new Apellidos()
            {
                Apellidos = "Bodnar"
            };
            var fechaDeNacimiento = new FechaDeNacimiento()
            {
                
            };
            
            var dniNie = new DNI_NIE()
            {
                
            };
            var respuesta = accionesUsuarios.Crear(peticion);

            Assert.True(respuesta.Nombre > 0);
            Assert.Equal(respuesta.Apellidos, usuario.Apellidos);
            Assert.Equal(respuesta.FechaDeNacimiento, usuario.FechaDeNacimiento);
            Assert.Equal(respuesta.DNI_NIE, usuario.DNI_NIE);
            
        }
        [Fact]
        public void ListarUsuarioExistente()
        {
            var nombre = new Nombre()
            {
                Nombre = "Andrea"
            };
            var apellidos = new Apellidos()
            {
                Apellidos = "Bodnar"
            };
            var fechaDeNacimiento = new FechaDeNacimiento()
            {

            };

            var dniNie = new DNI_NIE()
            {

            };
            contexto.Usuarios.Add(usuario);
            contexto.SaveChanges();
            
            var peticion = new ListarUsuarioRequest();
            var respuesta = accionesUsuarioss.Listar(peticion);
            //Entonces (T h e n)
            Assert.NotEmpty(respuesta.Elementos);
        }
        [Fact]