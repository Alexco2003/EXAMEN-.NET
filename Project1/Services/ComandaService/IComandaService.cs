using Project1.Data.Models;

namespace Project1.Services.ComandaService
{
    public interface IComandaService
    {
        Task<List<Comanda>> GetAll();
        Task Create(Comanda comanda);
        void Delete(Guid id);
        Task Update(Comanda comanda);
    }
}
