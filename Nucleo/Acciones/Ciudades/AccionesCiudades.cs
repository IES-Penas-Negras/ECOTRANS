using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IESPeniasNegras.Ecotrans.Nucleo.BBDD;
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Ciudades;
using AutoMapper;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Ciudades
{
    public class AccionesCiudades : IDisposable
    {

        private readonly DonacionesContext contexto;
        private readonly IMapper mapper;

        public AccionesCiudades(DonacionesContext? donacionesContext = null, IMapper? mapper = null)
        {
            if(donacionesContext == null)
            {
                contexto = new DonacionesContext();
            }
            else
            {
                contexto = donacionesContext;
            }
            this.mapper = mapper ?? new MapperConfiguration(cfg => cfg.AddProfile<CiudadesProfile>()).CreateMapper();

        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public ListarCiudadResponse Listar(ListarCiudadRequest listarCiudadRequest)
        {
            var listarCiudad = mapper.Map<Modelo.Ciudad>(listarCiudadRequest);
            contexto.Ciudades.SingleOrDefault(d => d.Id == id);

            return mapper.Map<ListarCiudadResponse>(listarCiudad);
        }


        public CrearCiudadResponse Crear(CrearCiudadRequest crearCiudadRequest)
        { 
            var crearCiudad = mapper.Map<Modelo.Ciudad>(crearCiudadRequest);
            contexto.Ciudades.Add(crearCiudad);
            contexto.SaveChanges();

            return mapper.Map<CrearCiudadResponse>(crearCiudad);
        }

      

        public EditarCiudadResponse Editar(EditarCiudadRequest editarCiudadRequest)
        {
            var editarCiudad = mapper.Map<Modelo.Ciudad>(editarCiudadRequest);
            if (editarCiudad == null)
                contexto.Ciudades.Add(editarCiudad);

            else
            {
                var ciudad = contexto.Ciudades.Single(d => d.Id == Ciudad.Id);
                
            

                contexto.SaveChanges();
            }

            return mapper.Map<EditarCiudadResponse>(editarCiudad);
        }

        public void Borrar(BorrarCiudadRequest borrarCiudadRequest)
        {
            var borrarCiudad = mapper.Map<Modelo.Ciudad>(borrar);
            contexto.Ciudades.Single(d => d.Id == borrarCiudad.Id);
            contexto.Ciudades.Remove(borrarCiudad);
            contexto.SaveChanges()
        }
    }
}

