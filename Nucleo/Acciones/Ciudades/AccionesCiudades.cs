using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecotrans.Nucleo.BBDD;
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Ciudades;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Ciudades
{
    public class AccionesCiudades : IDisposable
    {

        private readonly DonacionesContext contexto;
        private readonly IMapper mapper;

        public AccionesCiudades(DonacionesContext? donacionesContext = null)
        {
            if(donacionesContext == null)
            {
                contexto = new DonacionesContext();
            }
            else
            {
                contexto = donacionesContext;
            }
            this.mapper = mapper ?? new MapperConfiguration(cfg => cfg.AddProfile<ObjetosProfile>()).CreateMapper();

        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public ListarCiudadResponse Listar(ListarCiudadRequest listarCiudadRequest)
        {
            var listarCiudad = mapper.Map<Modelo.Ciudad>(listarCiudadRequest);
            return new ListarCiudadResponse();
        }


        public CrearCiudadResponse Crear(CrearCiudadRequest crearCiudadRequest)
        { 
            var crearCiudad = mapper.Map<Modelo.Ciudad>(crearCiudadRequest);
            return new CiudadResponse();
        }

      

        public EditarCiudadResponse Editar(EditarCiudadRequest editarCiudadRequest)
        {
            EditarCiudadResponse response = new EditarCiudadResponse();
            var editarCiudad = mapper.Map<Modelo.Ciudad>(editarCiudadRequest);
            return response;
        }

        public void Borrar(BorrarCiudadRequest borrar)
        {
            var borrarCiudad = mapper.Map<Modelo.Ciudad>(borrar);
        }
    }
}

