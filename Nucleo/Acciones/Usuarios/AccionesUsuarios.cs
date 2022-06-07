using AutoMapper;
using AutoMapper.QueryableExtensions;
using IESPeniasNegras.Ecotrans.Nucleo.BBDD;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo = IESPeniasNegras.Ecotrans.Nucleo.Model;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Usuarios
{
    public class AccionesUsuarios : IDisposable
    {
        private readonly DonacionesContext contexto;
        private readonly IMapper mapper;
        public AccionesUsuarios(DonacionesContext? donacionesContext = null, IMapper? mapper = null)
        {
            if (donacionesContext == null)
            {
                contexto = new DonacionesContext();
            }
            else
            {
                contexto = donacionesContext;
            }

            this.mapper = mapper ?? new MapperConfiguration(cfg => cfg.AddProfile<UsuariosProfile>()).CreateMapper();
        }
        public void Dispose()
        {
            contexto.Dispose();   
        }

        public ListarUsuarioResponse Listar(ListarUsuarioRequest listarUsuarioRequest)
        {
            var usuarios = contexto.Usuarios
               .Where(d => string.IsNullOrEmpty(listarUsuarioRequest.Buscar) || d.Usuario1.Contains(listarUsuarioRequest.Buscar))
               .ProjectTo<ListarUsuarioElemento>(mapper.ConfigurationProvider) 
               .ToList();

            return new ListarUsuarioResponse();
        }

      
    }
}
