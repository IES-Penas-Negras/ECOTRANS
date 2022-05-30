using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo = IESPeniasNegras.Ecotrans.Nucleo.Model;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Direcciones
{
    public class DireccionesProfile : Profile
    {
        public DireccionesProfile()
        {
            CreateMap<CrearDireccionRequest, Modelo.Direccion>();
            CreateMap<Modelo.Objeto, CrearDireccionResponse>();

            CreateMap<EditarCiudadRequest, Modelo.Direccion>();
            CreateMap<Modelo.Objeto, EditarCiudadResponse>();

            CreateMap<ListarCiudadRequest, Modelo.Direccion>();
            CreateMap<Modelo.Objeto, ListarCiudadResponse>();

            CreateMap<BorrarDireccionRequest, Modelo.Direccion>();
        }
    }
}
