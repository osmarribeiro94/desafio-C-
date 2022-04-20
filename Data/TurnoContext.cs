using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using challenge.Model;

namespace challenge.Data
{
    public class TurnoContext : DbContext
    {
        public TurnoContext(DbContextOptions<TurnoContext> options) : base(options)
        {
        }

        public DbSet<Turno> Turnos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var turma = modelBuilder.Entity<Turno>();
            turma.ToTable("tb_turno");
            turma.HasKey(x => x.Id);
            turma.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            turma.Property(x => x.Nome).HasColumnName("nome").IsRequired();
        }
    }
}
