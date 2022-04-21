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
            return await _context.Turmas.Include(x => x.Turnos).ToListAsync();
        }

         public void AdicionaTurma(Turma turma)
        {
            _context.Add(turma);
        }

        public async Task<Turma> BuscaTurma(int id)
        {
            return await _context.Turmas.Include(x => x.Turnos).Where(x => x.Id == id).FirstOrDefaultAsync();
        }


        public void AtualizaTurma(Turma turma)
        {
            _context.Update(turma);
        }

        public void DeletaTurma(Turma turma)
        {
            _context.Remove(turma);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}