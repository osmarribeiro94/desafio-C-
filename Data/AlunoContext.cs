using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using challenge.Model;


namespace challenge.Data
{
    public class AlunoContext : DbContext
    {
        public AlunoContext(DbContextOptions<AlunoContext> options) : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           var aluno = modelBuilder.Entity<Aluno>();
           aluno.ToTable("tb_aluno");
           aluno.HasKey(x => x.Id);
           aluno.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
           aluno.Property(x => x.Nome).HasColumnName("nome").IsRequired();
           aluno.Property(x => x.Matricula).HasColumnName("matricula");
           aluno.Property(x => x.DtNascimento).HasColumnName("data_nascimento");
        }
    }
}