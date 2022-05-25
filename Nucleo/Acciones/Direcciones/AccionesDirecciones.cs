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

            //añadir registro a la base de datos y guardarlos
            contexto.Direcciones.Add(crearDireccion);
            contexto.SaveChanges();

            return mapper.Map<CrearDireccionResponse>(crearDireccion);
        }

        public EditarDireccionResponse Editar(EditarDireccionRequest editarDireccionRequest)
        {

            //Single devuelve el elemento que cumple con la condición
            var editarDireccion = contexto.Direcciones.Single(d => d.Id == editarDireccionRequest.IdEdicion);

            if (editarDireccion != null)
            {
                mapper.Map(editarDireccionRequest, editarDireccion);

                // se puede hacer a través del automapper en una sola linea, (origen, destino)

                /*editarDireccion.ProvinciaId = editarDireccionRequest.ProvinciaId;
                editarDireccion.CiudadId = editarDireccionRequest.CiudadId;
                editarDireccion.Direccion1 = editarDireccionRequest.Direccion1;
                editarDireccion.Direccion2 = editarDireccionRequest.Direccion2;
                editarDireccion.CodigoPostal = editarDireccionRequest.CodigoPostal;*/
                
                contexto.SaveChanges();
            }

            return mapper.Map<EditarDireccionResponse>(editarDireccion);
        }

        public ListarDireccionResponse Listar(ListarDireccionRequest listarDireccionRequest)
        {
            var direcciones = contexto.Direcciones
               .Where(d => d.Id = id)
               .ProjectTo<ListarDireccionRequest>() 
               .ToList();
            //var direcciones = contexto.Direcciones.Where()

            return mapper.Map<ListarDireccionResponse>(direcciones);
        }

        public void Borrar(BorrarDireccionRequest borrarDireccionRequest)
        {
            // buscar el elemento por id, borrarlo y guardar los cambios
            var borrarDireccion = contexto.Direcciones.Single(d => d.Id == borrarDireccionRequest.Id);
            contexto.Direcciones.Remove(borrarDireccion);
            contexto.SaveChanges();
        }
    }
}
