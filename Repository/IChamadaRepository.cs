using challenge.Model;
namespace challenge.Repository
{
    public interface IChamadaRepository
    {
        void registraPresenca(Chamada chamada);

         public  List<Chamada> buscaChamadas();
        Task<bool> SaveChangesAsync();
    }
}