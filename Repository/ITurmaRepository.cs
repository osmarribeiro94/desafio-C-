using challenge.Model;

namespace challenge.Repository
{
    public interface ITurmaRepository
    {
        Task<IEnumerable<Turma>> BuscaTurmas();
        void AdicionaTurma(Turma turma);
        Task<Turma> BuscaTurma(int id);
        void AtualizaTurma(Turma turma);
        void DeletaTurma(Turma turma);

        Task<bool> SaveChangesAsync();
    }
}