using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo = IESPeniasNegras.Ecotrans.Nucleo.Model;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Donacion
{
    public class DonacionesProfile : Profile
    {
        public DonacionesProfile()
        {
            CreateMap<CrearDonacionRequest, Modelo.Donacion>();
            CreateMap<Modelo.Donacion, CrearDonacionResponse>();

            CreateMap<EditarDonacionRequest, Modelo.Donacion>();
            CreateMap<Modelo.Donacion, EditarDonacionResponse>();

            CreateMap<ListarDonacionRequest, Modelo.Donacion>();
            CreateMap<Modelo.Donacion, ListarDonacionResponse>();

            CreateMap<BorrarDonacionRequest, Modelo.Donacion>();
        }
    }
}
