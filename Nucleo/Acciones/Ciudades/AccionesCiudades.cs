using AutoMapper;
using AutoMapper.QueryableExtensions;
using IESPeniasNegras.Ecotrans.Nucleo.BBDD;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo = IESPeniasNegras.Ecotrans.Nucleo.Model;

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
            var ciudades = contexto.Ciudades;
               .Where(d => string.IsNullOrEmpty(listarCiudadRequest.Buscar) || d.Ciudad.Contains(listarCiudadRequest.Buscar))
               .ProjectTo<ListarCiudadElemento>(mapper.ConfigurationProvider)
               .ToList();

            return new ListarCiudadResponse();
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
            var editarCiudad = contexto.Ciudades.Single(d => d.Id == editarCiudadRequest.IdEdicion);

            if (editarCiudad != null)
            {
                mapper.Map(editarCiudadRequest, editarCiudad);
                contexto.SaveChanges();
            }
            return mapper.Map<EditarCiudadResponse>(editarCiudad);
        }

        public void Borrar(BorrarCiudadRequest borrarCiudadRequest)
        {
            var borrarCiudad = contexto.Ciudades.Single(d => d.Id == borrarCiudadRequest.Id);
            contexto.Ciudades.Remove(borrarCiudad);
            contexto.SaveChanges();
        }
    }
}

