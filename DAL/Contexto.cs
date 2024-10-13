using Microsoft.EntityFrameworkCore;
using RalfyGenao_Ap1_P1.Models;

namespace RalfyGenao_Ap1_P1.DAL
{
	public class Contexto : DbContext
	{
		public Contexto(DbContextOptions<Contexto> options)
				 : base(options) { }
		public DbSet<Prestamos> Prestamos { get; set; }
        public DbSet<Deudor> Duedor { get; set; }

        public DbSet<Cobros> Cobros { get; set; }

    }
}
