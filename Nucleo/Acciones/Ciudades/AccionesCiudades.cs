using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IESPeniasNegras.Ecotrans.Nucleo.BBDD;
using IESPeniasNegras.Ecotrans.Nucleo.Acciones.Ciudades;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Ciudades
{
    public class AccionesCiudades : IDisposable
    {

        private readonly DonacionesContext contexto;
        public AccionesCiudades(DonacionesContext? donacionesContext = null)
        {
            if(donacionesContext == null)
            {
                contexto = new DonacionesContext();
            }
            else
            {
                contexto = donacionesContext;
            }
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public void Listar()
        {
        }
        public void Crear()
        { 
        }

      

        public void Editar()
        {

        }

        public void Borrar()
        {

        }
    }
}

