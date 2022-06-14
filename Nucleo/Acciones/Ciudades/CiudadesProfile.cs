using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo = IESPeniasNegras.Ecotrans.Nucleo.Model;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Ciudades
{
    public class CiudadesProfile : Profile
    {
        public CiudadesProfile()
        {
            CreateMap<CrearCiudadRequest, Modelo.Ciudad>();
            CreateMap<Modelo.Ciudad, CrearCiudadResponse>();

            CreateMap<EditarCiudadRequest, Modelo.Ciudad>();
            CreateMap<Modelo.Ciudad, EditarCiudadResponse>();

            CreateMap<Modelo.Ciudad, ListarCiudadElemento>();

            CreateMap<BorrarCiudadRequest, Modelo.Ciudad>();
        }
    }
}
