using challenge.Model;
using challenge.Data;
using Microsoft.EntityFrameworkCore;

namespace challenge.Repository
{
    public class TurmaRepository : ITurmaRepository
    {
        private readonly TurmaContext _context;
        public TurmaRepository(TurmaContext repository)
        {
            _context = repository;
        }
        public async Task<IEnumerable<Turma>> BuscaTurmas()
        {
            return await _context.Turmas.ToListAsync();
        }
        public async Task<Turma> BuscaTurma(int id)
        {
            return await _context.Turmas.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        //  public void AdicionaAluno(Aluno aluno)
        // {
        //     _context.Add(aluno);
        // }

        // public void AtualizaAluno(Aluno aluno)
        // {
        //     _context.Update(aluno);
        // }

        // public void DeletaAluno(Aluno aluno)
        // {
        //     _context.Remove(aluno);
        // }

        // public async Task<bool> SaveChangesAsync()
        // {
        //     return await _context.SaveChangesAsync() > 0;
        // }
    }
}