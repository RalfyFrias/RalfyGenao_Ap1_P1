using Microsoft.EntityFrameworkCore;
using RalfyGenao_Ap1_P1.Models;

namespace RalfyGenao_Ap1_P1.DAL
{
	public class Contexto : DbContext
	{
        public Contexto(DbContextOptions<Contexto> options)
    : base(options) { }
        public DbSet<Prestamos> Prestamos { get; set; }
        public DbSet<Deudor> Deudor { get; set; }
        public DbSet<Cobros> Cobros { get; set; }
        public DbSet<CobroDetalle> cobroDetalle { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Deudor>().HasData(new List<Deudor>()
        {
            new Deudor() {DeudorId=1, Nombres="Ralfy"},
             new Deudor() {DeudorId=2, Nombres="Joshua"},
              new Deudor() {DeudorId=3, Nombres="Juanes"},
               new Deudor() {DeudorId=4, Nombres="eddy"},
                new Deudor() {DeudorId=5, Nombres="Penda"}
        });
        }
    }
}
