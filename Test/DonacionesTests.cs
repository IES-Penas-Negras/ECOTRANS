using Xunit;
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Objeto;
using IESPeniasNegras.Ecotrans.Nucleo.BBDD;
namespace IESPeniasNegras.Ecotrans.Test;

public class DonacionesObjeto
{
    public DonacionesObjeto()
    {
        public DonacionesObjeto(DonacionesContext? donacionesContext = null, IMapper? mapper = null)
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
}
