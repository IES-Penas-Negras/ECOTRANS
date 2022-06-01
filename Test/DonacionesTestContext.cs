using IESPeniasNegras.Ecotrans.Nucleo.BBDD;
using Microsoft.EntityFrameworkCore;

namespace IESPeniasNegras.Ecotrans.Test
{
	public class DonacionesTestContext : DonacionesContext
	{		
		
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseInMemoryDatabase("DonacionesTest");
            //options.UseSqlServer();	
        }        
	}

}