using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Direcciones
{
    public class CrearDireccionResponse
    {
        public int Id { get; set; }
        public int ProvinciaId { get; set; }
        public int CiudadId { get; set; }
        public string Direccion1 { get; set; }
        public string? Direccion2 { get; set; }
        public int CodigoPostal { get; set; }
    }
}
