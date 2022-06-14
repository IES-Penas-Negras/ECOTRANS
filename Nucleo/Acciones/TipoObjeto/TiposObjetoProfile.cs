using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo = IESPeniasNegras.Ecotrans.Nucleo.Model;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.TipoObjeto
{
    public class TiposObjetoProfile : Profile
    {
        public TiposObjetoProfile()
        {
            CreateMap<CrearTipoObjetoRequest, Modelo.TipoObjeto>();
            CreateMap<Modelo.TipoObjeto, CrearTipoObjetoResponse>();

            CreateMap<EditarTipoObjetoRequest, Modelo.TipoObjeto>();
            CreateMap<Modelo.TipoObjeto, EditarTipoObjetoResponse>();

            CreateMap<Modelo.TipoObjeto, ListarTipoObjetoElemento>();

            CreateMap<BorrarTipoObjetoRequest, Modelo.TipoObjeto>();

        }
    }
}
