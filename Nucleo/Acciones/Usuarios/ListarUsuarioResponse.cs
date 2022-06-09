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
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int FechaDeNacimiento { get; set; }
        public int DNI_NIE { get; set; }
        public string? Género { get; set; }
    }
}
