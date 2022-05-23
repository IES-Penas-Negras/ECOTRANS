using IESPeniasNegras.Ecotrans.Nucleo.BBDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Direcciones
{
    public class AccionesDirecciones : IDisposable
    {
        private DonacionesContext contexto;
        public AccionesDirecciones()
        {
            contexto = new DonacionesContext();
        }
        public void Dispose()
        {
            contexto.Dispose();   
        }
        public CrearDireccionResponse Crear(CrearDireccionRequest crearDireccionRequest)
        {
            var crearDireccion = contexto.Direcciones;
            return new CrearDireccionResponse();
        }

        public EditarDireccionResponse Editar(EditarDireccionRequest editarDireccionRequest)
        {
            var editarDireccion = contexto.Direcciones;
            return new EditarDireccionResponse();
        }

        public ListarDireccionResponse Listar(ListarDireccionRequest listarDireccionRequest, int id)
        {
            var listarDireccion = contexto.Direcciones.SingleOrDefault(d => d.Id == id);
            return new ListarDireccionResponse();
        }

        public void Borrar(BorrarDireccionRequest borrarDireccionRequest)
        {
            var borrarDireccion = contexto.Direcciones;
        }
    }
}
