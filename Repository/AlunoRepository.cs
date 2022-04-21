using challenge.Model;
using challenge.Data;
using Microsoft.EntityFrameworkCore;

namespace challenge.Repository
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly AlunoContext _context;
        public AlunoRepository(AlunoContext repository)
        {
            _context = repository;
        }
        public void AdicionaAluno(Aluno aluno)
        {
            _context.Add(aluno);
        }

        public void AtualizaAluno(Aluno aluno)
        {
            _context.Update(aluno);
        }

        public async Task<IEnumerable<Aluno>> BuscaAlunos()
        {
            return await _context.Alunos.Include(x => x.Turmas).Include(x => x.Turmas.Turnos).ToListAsync();
        }

          public async Task<IEnumerable<Aluno>> BuscaAlunosByTurmaId(int turmaId)
        {
            return await _context.Alunos.Include(x =>x.Turmas).Include(x => x.Turmas.Turnos).Where(x => x.Turmas.Id == turmaId).ToListAsync();
        }
        public async Task<Aluno> BuscaAluno(int id)
        {
             return await _context.Alunos.Include(x =>x.Turmas).Include(x => x.Turmas.Turnos).Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public void DeletaAluno(Aluno aluno)
        {
            _context.Remove(aluno);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}