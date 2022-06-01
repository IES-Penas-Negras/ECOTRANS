


using System;
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Donacion;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Donacion;
public class AccionesDonacion
{
    public CrearDonacionResponse Crear(CrearDonacionRequest crearDonacionRequest)
    {
        CrearDonacionResponse response = new CrearDonacionResponse();
            return response;
    }
     
    public ListarDonacionResponse Listar(ListarDonacionRequest listarDonacionRequest)
    {
        ListarDonacionResponse response = new ListarDonacionResponse();
            return response;

    }

    public EditarDonacionResponse Editar(EditarDonacionRequest editar)
    {
        EditarDonacionResponse response = new EditarDonacionResponse();
            return response;
    }
    
    public void Borrar(BorrarDonacionRequest borrarDonacionRequest)
    {
        
    }
}