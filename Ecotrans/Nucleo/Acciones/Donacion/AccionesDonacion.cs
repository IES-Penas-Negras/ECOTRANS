using IESPeñasNegras.Ecotrans.Nucleo.Donacion.CrearDonacionRequest;
using IESPeñasNegras.Ecotrans.Nucleo.Donacion.CrearDonacionResponse;
using System;
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Donacion;

namespace IESPeniasNegras.Ecotrans.Nucleo.AccionesDonacion;
public class AccionesDonacion
{
    public void Crear(CrearDonacionRequest CrearDonacionResponse)
    {}
     
    public ListarDonacionResponse Listar(ListarDonacionResponse listarDonacionResponse)
    {
        return new ListarDonacionResponse();
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