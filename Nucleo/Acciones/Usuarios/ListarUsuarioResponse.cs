using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Usuarios
{
    public class ListarUsuarioResponse
    {
        public List<ListarUsuarioElemento> Elementos { get; set; }

    }

    public class ListarUsuarioElemento
    {
        public int Id {get; set;}
        public string Nombre { get; set; }
    }
}
