using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo = IESPeniasNegras.Ecotrans.Nucleo.Model;


namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Objeto
{
    public class ObjetosProfile : Profile
    {
        public ObjetosProfile()
        {
            CreateMap<CrearObjetoRequest, Modelo.Objeto>();
            CreateMap<Modelo.Objeto, CrearObjetoResponse>();

            CreateMap<EditarObjetoRequest, Modelo.Objeto>();
            CreateMap<Modelo.Objeto, EditarObjetoResponse>();

            CreateMap<Modelo.Objeto, ListarObjetoElemento>();

            CreateMap<BorrarObjetoRequest, Modelo.Objeto>();

        }
    }
}
