using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using challenge.Model;
namespace challenge.Data
{
    public class ChamadaContext: DbContext
    {
        public ChamadaContext(DbContextOptions<ChamadaContext> options) : base(options)
        {
        }

        public DbSet<Chamada> chamadas {get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var turno = modelBuilder.Entity<Chamada>();
            turno.ToTable("Chamada");
            turno.HasKey(x => x.id);
            turno.Property(x => x.id).HasColumnName("id").ValueGeneratedOnAdd();
            turno.Property(x => x.idAluno).HasColumnName("id_aluno");
            turno.Property(x => x.idTurma).HasColumnName("id_turma");
            turno.Property(x => x.data).HasColumnName("data");
            turno.Property(x => x.presenca).HasColumnName("presenca");
        }
    }
}