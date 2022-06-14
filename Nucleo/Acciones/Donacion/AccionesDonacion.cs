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
using AutoMapper.QueryableExtensions;

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

        contexto.Donaciones.Add(crearDonacion);
        contexto.SaveChanges();

        return mapper.Map<CrearDonacionResponse>(crearDonacion);
    }

    public EditarDonacionResponse Editar(EditarDonacionRequest editar)
    {
        EditarDonacionResponse response = new EditarDonacionResponse();
        var donacionEditada = contexto.Donaciones.Single(d => d.Id == editar.IdEdicion);

         if (donacionEditada != null)
        {
            mapper.Map(editar, donacionEditada); 
            contexto.SaveChanges();
        }
        return mapper.Map<EditarDonacionResponse>(donacionEditada);
    }

    public ListarDonacionResponse Listar(ListarDonacionRequest listarDonacionRequest)
    {
        var donaciones = contexto.Donaciones
               .Where(d => string.IsNullOrEmpty(listarDonacionRequest.Buscar) || d.Titulo.Contains(listarDonacionRequest.Buscar))
               .ProjectTo<ListarDonacionElemento>(mapper.ConfigurationProvider) 
               .ToList();
        return new ListarDonacionResponse(donaciones);
    }

    //public ListarObjetoResponse Listar(ListarObjetoRequest listarObjetoRequest)
    //{
    //    var objetos = contexto.Objetos.Where(d => string.IsNullOrEmpty(listarObjetoRequest.Buscar) || d.Nombre.Contains(listarObjetoRequest.Buscar))
    //       .ProjectTo<ListarObjetoElemento>(mapper.ConfigurationProvider)
    //       .ToList();

    //    return new ListarObjetoResponse(objetos);
    //}
    public void Borrar(BorrarDonacionRequest borrar)
    {
        var donacionBorrada = contexto.Donaciones.Single(d => d.Id == borrar.Id);
        contexto.Donaciones.Remove(donacionBorrada);
        contexto.SaveChanges();
    }
}