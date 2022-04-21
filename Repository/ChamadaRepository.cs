using challenge.Model;
using challenge.Data;
namespace challenge.Repository
{
    public class ChamadaRepository : IChamadaRepository

    {
        private readonly ChamadaContext _context;
        public ChamadaRepository(ChamadaContext repository)
        {
            _context = repository;
        }
        public void registraPresenca(Chamada chamada)
        {
            _context.Add(chamada);
        }

        public List<Chamada> buscaChamadas()
        {
            return _context.chamadas.ToList();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}