using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Objetos;

    public class BorrarObjetoRequest
    {
        public BorrarObjetoRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }


    }

