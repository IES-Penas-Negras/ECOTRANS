using System;
using Microsoft.EntityFrameworkCore;

namespace Ecotrans.Nucleo.BBDD
{
	public class DonacionesContext : DBContext
	{


		public string ConnectionString = "Server=Localhost;Database=Vidly;Trusted_Connection=True;";
		protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer(ConnectionString);
	}
}

