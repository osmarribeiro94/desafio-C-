using challenge.Model;

namespace challenge.Repository
{
    public interface ITurnoRepository
    {
        Task<IEnumerable<Turno>> BuscaTurnos();
        Task<Turno> BuscaTurnoById(int turmaId);
       
        // void AdicionaAluno(Aluno aluno);
        // void AtualizaAluno(Aluno aluno);
        // void DeletaAluno(Aluno aluno);

        // Task<bool> SaveChangesAsync();
    }
}