﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IESPeñasNegras.Ecotrans.Nucleo.Acciones.Objeto;

namespace Nucleo.Acciones.Objeto
{
    internal class AccionesObjeto
    {
        public void Crear() { }
        public ListarObjetoResponse Listar(ListarObjetoRequest listarObjetoRequest ) 
        { 
            return new ListarObjetoResponse(); 
            
        }
        public void Editar() { }
        public void Borrar() { }

    }
}
