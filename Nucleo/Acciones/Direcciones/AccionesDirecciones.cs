using AutoMapper;
using IESPeniasNegras.Ecotrans.Nucleo.BBDD;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo = IESPeniasNegras.Ecotrans.Nucleo.Model;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Direcciones
{
    public class AccionesDirecciones : IDisposable
    {
        private readonly DonacionesContext contexto;
        private readonly IMapper mapper;
        public AccionesDirecciones(DonacionesContext? donacionesContext = null, IMapper? mapper = null)
        {
            if (donacionesContext == null)
            {
                contexto = new DonacionesContext();
            }
            else
            {
                contexto = donacionesContext;
            }

            this.mapper = mapper ?? new MapperConfiguration(cfg => cfg.AddProfile<DireccionesProfile>()).CreateMapper();
        }
        public void Dispose()
        {
            contexto.Dispose();   
        }

        public CrearDireccionResponse Crear(CrearDireccionRequest crearDireccionRequest)
        {
            var crearDireccion = mapper.Map<Modelo.Direccion>(crearDireccionRequest);

            contexto.Direcciones.Add(crearDireccion);
            contexto.SaveChanges();

            return mapper.Map<CrearDireccionResponse>(crearDireccion);
        }

        public EditarDireccionResponse Editar(EditarDireccionRequest editarDireccionRequest)
        {
            var editarDireccion = mapper.Map<Modelo.Direccion>(editarDireccionRequest);

            if (editarDireccion == null)
                contexto.Direcciones.Add(editarDireccion);

            else
            {
                var direccion = contexto.Direcciones.Single(d => d.Id == editarDireccion.Id);
                
                direccion.ProvinciaId = editarDireccion.ProvinciaId;
                direccion.CiudadId = editarDireccion.CiudadId;
                direccion.Direccion1 = editarDireccion.Direccion1;
                direccion.Direccion2 = editarDireccion.Direccion2;
                direccion.CodigoPostal = editarDireccion.CodigoPostal;

                contexto.SaveChanges();
            }

            return mapper.Map<EditarDireccionResponse>(editarDireccion);
        }

        public ListarDireccionResponse Listar(ListarDireccionRequest listarDireccionRequest, int id)
        {
            var listarDireccion = mapper.Map<Modelo.Direccion>(listarDireccionRequest);

            contexto.Direcciones.SingleOrDefault(d => d.Id == id);

            return mapper.Map<ListarDireccionResponse>(listarDireccion);
        }

        public void Borrar(BorrarDireccionRequest borrarDireccionRequest)
        {
            var borrarDireccion = mapper.Map<Modelo.Direccion>(borrarDireccionRequest);

            contexto.Direcciones.Single(d => d.Id == borrarDireccion.Id);
            contexto.Direcciones.Remove(borrarDireccion);
            contexto.SaveChanges();
        }
    }
}
