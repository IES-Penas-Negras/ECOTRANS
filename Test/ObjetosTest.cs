using Xunit;
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Objeto;
using IESPeniasNegras.Ecotrans.Nucleo.BBDD;



namespace TestUnitarios
{
    private readonly DonacionesContext contextoObjeto; //punto 2
    var objetoTipoAcciones = new AccionesObjeto(contextoObjeto);//punto 3
    [Fact]//ounto 4 - falta pasarle la clase
    public void Debe_Crear_Un_Objeto_Al_Llamar_A_La_Accion_Crear()
    {

    }
    public void Editar()
    {

    }
    public void Listar()
    {
        
    }
    public void Borrar()
    {
        
    }
}
