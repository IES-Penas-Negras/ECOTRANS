using AutoMapper;
using AutoMapper.QueryableExtensions;
using IESPeniasNegras.Ecotrans.Nucleo.BBDD;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IESPeniasNegras.Ecotrans.Nucleo.BBDD;
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Ciudades;
using AutoMapper;
using Modelo = IESPeniasNegras.Ecotrans.Nucleo.Model;
using AutoMapper.QueryableExtensions;

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
           /* var listarCiudad = mapper.Map<Modelo.Ciudad>(listarCiudadRequest);
            contexto.Ciudades.SingleOrDefault(d => d.Id == id);

            return mapper.Map<ListarCiudadResponse>(listarCiudad); */

            var ciudades = contexto.Ciudades
               .Where(d => string.IsNullOrEmpty(listarCiudadRequest.Buscar) || d.Nombre.Contains(listarCiudadRequest.Buscar))
               .ProjectTo<ListarCiudadElemento>(mapper.ConfigurationProvider) 
               .ToList();

            return new ListarCiudadResponse(ciudades);
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
            var ciudadEditada = contexto.Ciudades.Single(d => d.Id == editarCiudadRequest.IdEdicion);

            if (ciudadEditada != null)
            {
                mapper.Map(editarCiudadRequest, ciudadEditada);
                contexto.SaveChanges();
            }

            return mapper.Map<EditarCiudadResponse>(ciudadEditada);
        }

        public void Borrar(BorrarCiudadRequest borrar)
        {
            var ciudadBorrada = contexto.Ciudades.Single(d => d.Id == borrar.Id);
            contexto.Ciudades.Remove(ciudadBorrada);
            contexto.SaveChanges();
        }
    }
}

