
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Objeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IESPeniasNegras.Ecotrans.Nucleo.BBDD;
using AutoMapper;
using Modelo = IESPeniasNegras.Ecotrans.Nucleo.Model;
using AutoMapper.QueryableExtensions;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Objeto
{
    public class AccionesObjeto : IDisposable
    {
        private readonly DonacionesContext contexto;
        private readonly IMapper mapper;

        public AccionesObjeto(DonacionesContext? donacionesContext = null, IMapper? mapper = null)
        {
            if (donacionesContext == null)
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

        public CrearObjetoResponse Crear(CrearObjetoRequest crearObjetoRequest)
        {
            var crearObjeto = mapper.Map<Modelo.Objeto>(crearObjetoRequest);

            contexto.Objetos.Add(crearObjeto);
            contexto.SaveChanges();

            return mapper.Map<CrearObjetoResponse>(crearObjeto);
        }

        public EditarObjetoResponse Editar(EditarObjetoRequest editar)
        {
            EditarObjetoResponse response = new EditarObjetoResponse();
            var editarObjeto = mapper.Map<Modelo.Objeto>(editar);
            if (editarObjeto != null)
            {
                mapper.Map(editar, editarObjeto); 
                contexto.SaveChanges();
            }
            return mapper.Map<EditarObjetoResponse>(editarObjeto);
        }

        public ListarObjetoResponse Listar(ListarObjetoRequest listarObjetoRequest)
        {
            var listarObjeto = mapper.Map<Modelo.Objeto>(listarObjetoRequest);
            var objetos = contexto.Objetos
               .Where(d => string.IsNullOrEmpty(listarObjetoRequest.Buscar) || d.Nombre.Contains(listarObjetoRequest.Buscar))
               .ProjectTo<ListarObjetoElemento>(mapper.ConfigurationProvider) 
               .ToList();
            return new ListarObjetoResponse();
        }

        public void Borrar(BorrarObjetoRequest borrar) 
        {
            var borrarObjeto = contexto.Objetos.Single(d => d.Id == borrar.Id);
            contexto.Objetos.Remove(borrarObjeto);
            contexto.SaveChanges();
        }

    }
}

