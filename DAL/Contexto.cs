using Microsoft.EntityFrameworkCore;

namespace RalfyGenao_Ap1_P1.DAL
{
	public class Contexto : DbContext
	{
		public Contexto(DbContextOptions<Contexto> options)
				 : base(options) { }
		public DbSet<Registro> registros { get; set; }

	}
}
