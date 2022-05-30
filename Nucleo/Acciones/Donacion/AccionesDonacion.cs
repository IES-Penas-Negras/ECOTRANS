using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Donacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IESPeniasNegras.Ecotrans.Nucleo.BBDD;
using AutoMapper;
using Modelo = IESPeniasNegras.Ecotrans.Nucleo.Model;
using Microsoft.AspNetCore.Mvc;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Donacion;


public class AccionesDonacion : IDisposable
{
    private readonly DonacionesContext contexto;
    private readonly IMapper mapper;

    public AccionesDonacion(DonacionesContext? donacionesContext = null, IMapper? mapper = null)
        {
            if (donacionesContext == null)
            {
                contexto = new DonacionesContext();
            }
            else
            {
                contexto = donacionesContext;
            }

            this.mapper = mapper ?? new MapperConfiguration(cfg => cfg.AddProfile<DonacionesProfile>()).CreateMapper();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }


    public CrearDonacionResponse Crear(CrearDonacionRequest crearDonacionRequest)
    {
        var crearDonacion = mapper.Map<Modelo.Donacion>(crearDonacionRequest);
        return new CrearDonacionResponse();
    }

    public EditarDonacionResponse Editar(EditarDonacionRequest editar)
    {
        EditarDonacionResponse response = new EditarDonacionResponse();
        var editarDonacion = mapper.Map<Modelo.Donacion>(editar);
        return response;
    }

    public ActionResult<CrearDonacionResponse> Post(AccionesDonacion accionesDonacionPost)
    {
        throw new NotImplementedException();
    }

    public ListarDonacionResponse Listar(ListarDonacionRequest listarDonacionRequest)
    {
        var listarDonacion = mapper.Map<Modelo.Donacion>(listarDonacionRequest);
        return new ListarDonacionResponse();
    }

    
    public void Borrar(BorrarDonacionRequest borrar)
    {
        var borrarDonacion = mapper.Map<Modelo.Donacion>(borrar);
    }
}