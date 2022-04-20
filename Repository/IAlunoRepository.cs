using challenge.Model;

namespace challenge.Repository
{
    public interface IAlunoRepository
    {
        Task<IEnumerable<Aluno>> BuscaAlunos();
        Task<Aluno> BuscaAluno(int id);
        void AdicionaAluno(Aluno aluno);
        void AtualizaAluno(Aluno aluno);
        void DeletaAluno(Aluno aluno);

        Task<bool> SaveChangesAsync();
    }
}