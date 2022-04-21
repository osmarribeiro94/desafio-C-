using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using challenge.Model;

namespace challenge.Data
{
    public class TurnoContext : DbContext
    {
        public TurnoContext(DbContextOptions<TurnoContext> options) : base(options)
        {
        }

        public DbSet<Turno> turnos {get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var turno = modelBuilder.Entity<Turno>();
            turno.ToTable("Turno");
            turno.HasKey(x => x.Id);
            turno.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            turno.Property(x => x.Nome).HasColumnName("nome");
        }
    }
}