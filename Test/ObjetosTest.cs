using Xunit;
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Objeto;
using IESPeniasNegras.Ecotrans.Nucleo.BBDD;
using IESPeniasNegras.Ecotrans.Nhcleo.Acciones.Donacion;
public class ObjetosTest
{
    public ObjetosTest()//punto 2
    {
        public AccionesObjeto contextoDonaciones(DonacionesContext? donacionesContext = null, IMapper? mapper = null)
        {
            if (donacionesContext == null)
            {
                contexto = new DonacionesContext();
            }
            else
            {
                contexto = donacionesContext;
            }
        }
        var objetoTipoAcciones = new AccionesObjeto(contexto);//punto 3
    }

    public void Debe_Crear_Un_Objeto_Al_Llamar_A_La_Accion_Crear(CrearDonacionRequest CrearDonacionResponse)
    {

    }
    public ListarDonacionResponse Debe_Editar_Un_Objeto_Al_Llamar_A_La_Accion_Editar(ListarDonacionResponse listarDonacionResponse)
    {
        return new ListarDonacionResponse();
    }
    public EditarDonacionResponse Debe_Listar_Un_Objeto_Al_Llamar_A_La_Accion_Listar(EditarDonacionRequest editar)
    {
        EditarDonacionResponse response = new EditarDonacionResponse();
            return response;
    }
    public void Debe_Borrar_Un_Objeto_Al_Llamar_A_La_Accion_Borrar(BorrarDonacionRequest borrarDonacionRequest)
    {

    }

}
