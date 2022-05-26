using System;
using 

namespace IESPeniasNegras.Ecotrans.Test;


namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Test.Ciudades
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
