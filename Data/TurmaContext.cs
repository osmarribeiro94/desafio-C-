using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using challenge.Model;

namespace challenge.Data
{
    public class TurmaContext : DbContext
    {
        public TurmaContext(DbContextOptions<TurmaContext> options) : base(options)
        {
        }

        public DbSet<Turma> Turmas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var turma = modelBuilder.Entity<Turma>();
            turma.ToTable("Turma");
            turma.HasKey(x => x.Id);
            turma.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            turma.Property(x => x.Nome).HasColumnName("Nome");
            // turma.Property(x => x.Turno).HasColumnName("turno");
        }
    }
}
