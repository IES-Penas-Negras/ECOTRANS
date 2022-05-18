using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Objeto;
using IESPeniasNegras.Ecotrans.Nucleo.Model;

namespace IESPeniasNegras.Ecotrans.MVC.Models
{
    public class EditarObjetoViewModel : EditarObjetoRequest
    {
       public TipoObjeto TipoObjeto { get; set; }
       public IEnumerable<Estado> Estado { get; set; }

    }
}
