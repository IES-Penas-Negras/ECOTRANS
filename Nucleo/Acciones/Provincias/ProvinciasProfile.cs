using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo = IESPeniasNegras.Ecotrans.Nucleo.Model;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Provincias
{
    public class ProvinciasProfile : Profile
    {
        public ProvinciasProfile()
        {
          
            CreateMap<Modelo.Provincia, ListarProvinciaElemento>();

        }
    }
}
