using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo = IESPeniasNegras.Ecotrans.Nucleo.Model;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Usuarios
{
    public class UsuariosProfile : Profile
    {
        public UsuariosProfile()
        {
            
            CreateMap<Modelo.Usuario, ListarUsuarioElemento>() 
                .ForMember(src => src.Nombre, 
                    dest => dest.MapFrom(r => r.UserName));
  
        }
    }
}
