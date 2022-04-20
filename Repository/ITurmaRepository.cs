using challenge.Model;

namespace challenge.Repository
{
    public interface ITurmaRepository
    {
        Task<IEnumerable<Turma>> BuscaTurmas();
        Task<Turma> BuscaTurma(int id);
        // void AdicionaAluno(Aluno aluno);
        // void AtualizaAluno(Aluno aluno);
        // void DeletaAluno(Aluno aluno);

        // Task<bool> SaveChangesAsync();
    }
}