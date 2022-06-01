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

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Provincias

public class AccionesProvincias : IDisposable
{
    private readonly DonacionesContext contexto;
    private readonly IMapper mapper;

    public AccionesProvincias(DonacionesContext? donacionesContext = null, IMapper? mapper = null)
    {
        if (donacionesContext == null)
        {
            contexto = new DonacionesContext();
        }
        else
        {
            contexto = donacionesContext;
        }
        this.mapper = mapper ?? new MapperConfiguration(cfg => cfg.AddProfile<ProvinciasProfile>()).CreateMapper();

    }

    public void Dispose()
    {
        contexto.Dispose();
    }

    public ListarProvinciaResponse Listar(ListarProvinciaRequest listarProvinciaRequest)
    {
        var provincias = contexto.Provincias
               .Where(d => string.IsNullOrEmpty(listarProvinciaRequest.Buscar) || d.Provincia.Contains(listarProvinciaRequest.Buscar))
               .ProjectTo<ListarProvinciaRequest>(mapper.ConfigurationProvider)
               .ToList();

        return new ListarProvinciaResponse();
    }


    

    




}
