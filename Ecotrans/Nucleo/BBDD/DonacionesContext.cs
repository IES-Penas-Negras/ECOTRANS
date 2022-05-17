using System;
using Microsoft.EntityFrameworkCore;

namespace Ecotrans.Nucleo.BBDD
{
	public class DonacionesContext : DbContext
	{
		public string ConnectionString = "Server=Localhost;Database=Ecotrans;Trusted_Connection=True;";
		protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer(ConnectionString);
		public DbSet <Objeto> Objetos { get; set; }
		public DbSet <Ciudad> Ciudades { get; set; }
	}

}

