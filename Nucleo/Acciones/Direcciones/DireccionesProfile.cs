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
            CreateMap<Modelo.Direccion, CrearDireccionResponse>();

            CreateMap<EditarDireccionRequest, Modelo.Direccion>();
            CreateMap<Modelo.Direccion, EditarDireccionResponse>();

            CreateMap<ListarDireccionRequest, Modelo.Direccion>();
            CreateMap<Modelo.Direccion, ListarDireccionElemento>();

            CreateMap<BorrarDireccionRequest, Modelo.Direccion>();
        }
    }
}
