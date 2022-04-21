using challenge.Model;
using challenge.Data;
using Microsoft.EntityFrameworkCore;

namespace challenge.Repository
{
    public class TurnoRepository : ITurnoRepository
    {
        private readonly TurnoContext _context;
        public TurnoRepository(TurnoContext repository)
        {
            _context = repository;
        }
        public async Task<IEnumerable<Turno>> BuscaTurnos()
        {
            return await _context.turnos.ToListAsync();
        }

         public async Task<Turno> BuscaTurnoById(int id)
        {
            return await _context.turnos.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}