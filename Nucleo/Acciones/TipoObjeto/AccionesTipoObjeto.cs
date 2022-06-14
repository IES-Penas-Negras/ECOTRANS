using AutoMapper;
using IESPeniasNegras.Ecotrans.Nucleo.BBDD;
using AutoMapper.QueryableExtensions;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.TipoObjeto
{
    public class AccionesTipoObjeto
    {
        private readonly DonacionesContext contexto;
        private readonly IMapper mapper;
        public AccionesTipoObjeto (DonacionesContext? donacionesContext = null, IMapper? mapper = null)
        {
            if (donacionesContext == null)
            {
                contexto = new DonacionesContext();
            }
            else
            {
                contexto = donacionesContext;
            }

            this.mapper = mapper ?? new MapperConfiguration(cfg => cfg.AddProfile<TiposObjetoProfile>()).CreateMapper();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }
        public CrearTipoObjetoResponse Crear(CrearTipoObjetoRequest crearTipoObjetoRequest)
        {
            var crearTipoObjeto = mapper.Map<Model.TipoObjeto>(crearTipoObjetoRequest);
            contexto.TiposObjetos.Add(crearTipoObjeto);
            contexto.SaveChanges();
            return mapper.Map<CrearTipoObjetoResponse>(crearTipoObjeto);
        }

        public EditarTipoObjetoResponse Editar(EditarTipoObjetoRequest editarTipoObjetoRequest)
        {
            var editarTipoObjeto = contexto.TiposObjetos.Single(d => d.Id == editarTipoObjetoRequest.IdEdicion);

            if (editarTipoObjeto != null)
            {
                mapper.Map(editarTipoObjetoRequest, editarTipoObjeto);
                contexto.SaveChanges();
            }
            return mapper.Map<EditarTipoObjetoResponse>(editarTipoObjeto);
        }

        public ListarTipoObjetoResponse Listar(ListarTipoObjetoRequest listarTipoObjetoRequest)
        {
            var tipoObjetos = contexto.TiposObjetos
                .Where(d => string.IsNullOrEmpty(listarTipoObjetoRequest.Buscar) || d.Nombre.Contains(listarTipoObjetoRequest.Buscar))
                .ProjectTo<ListarTipoObjetoElemento>(mapper.ConfigurationProvider)
                .ToList();
            return new ListarTipoObjetoResponse(tipoObjetos);

        }

        public void Borrar(BorrarTipoObjetoRequest borrarTipoObjetoRequest)
        {
            var borrarTipoObjeto = contexto.TiposObjetos.Single(d => d.Id == borrarTipoObjetoRequest.Id);
            contexto.TiposObjetos.Remove(borrarTipoObjeto);
            contexto.SaveChanges(); 
        }

    }
}
