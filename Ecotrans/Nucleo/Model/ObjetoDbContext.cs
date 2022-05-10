using System;
using Microsoft.EntityFrameworkCore;


namespace IESPeñasNegras.Ecotrans.Modelo.Objeto.DbContext
{
	public class ObjetoDbContext : DbContext
	{

	public DbSet <Objeto> Objeto { get; set; }
	
	}


} 

	
