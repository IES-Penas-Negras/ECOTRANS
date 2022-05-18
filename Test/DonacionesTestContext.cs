namespace IESPeniasNegras.Ecotrans.TestUnitarios
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