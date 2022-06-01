using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IESPeniasNegras.Ecotrans.Nucleo.BBDD;
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Provincias;
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Provincia;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Provincias

public class AccionesProvincias
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
        var listarProvincia = mapper.Map<Modelo.Provincia>(listarProvinciaRequest);
        contexto.Provincias.SingleOrDefault(d => d.Id == id);

        return mapper.Map<ListarProvinciaResponse>(listarProvincia);
    }


    public CrearProvinciaResponse Crear(CrearProvinciaRequest crearProvinciaRequest)
    {
        var crearProvincia = mapper.Map<Modelo.Provincia>(crearProvinciaRequest);
        contexto.Provincias.Add(crearProvincia);
        contexto.SaveChanges();

        return mapper.Map<CrearProvinciaResponse>(crearProvincia);
    }

    public object Listar(ListarProvinciaRequest peticion)
    {
        throw new NotImplementedException();
    }

    public EditarProvinciaResponse Editar(EditarProvinciaRequest editarProvinciaRequest)
    {
        var editarProvincia = mapper.Map<Modelo.Provincia>(editarProvinciaRequest);
        if (editarProvincia == null)
            contexto.Provincias.Add(editarProvincia);

        else
        {
            var provincia = contexto.Provincias.Single(d => d.Id == Provincia.Id);
            


            contexto.SaveChanges();
        }

        return mapper.Map<EditarProvinciaResponse>(editarProvincia);
    }

    public void Borrar(BorrarProvinciaRequest borrarProvinciaRequest)
    {
        var borrarProvincia = mapper.Map<Modelo.Provincia>(borrar);
        contexto.Provincias.Single(d => d.Id == borrarProvincia.Id);
        contexto.Provincias.Remove(borrarProvincia);
        contexto.SaveChanges()
    }




}
