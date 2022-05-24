using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using IESPeniasNegras.Ecotrans.Nucleo.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace IESPeniasNegras.Ecotrans.Nucleo.BBDD
{
	public class DonacionesContext : IdentityDbContext<Usuario, Rol, int>
	{
		public string ConnectionString = "Server=Localhost;Database=Ecotrans;Trusted_Connection=True;";
		protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer(ConnectionString);
		public DbSet <Objeto> Objetos { get; set; }
		public DbSet<Ciudad> Ciudades { get; set; }
		public DbSet<Provincia> Provincias { get; set; }
		public DbSet<Donacion> Donaciones { get; set; }
		public DbSet<Direccion> Direcciones { get;set; }
        public DbSet<Usuario> Usuarios { get; set; }
		public DbSet<Rol> Roles { get; set; }
	}

}

