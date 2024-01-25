using Project1.Data.Models;

namespace Project1.Services.ComandaProdusService
{
    public interface IComandaProdusService
    {
        Task<List<ComandaProdus>> GetAll();
        Task Create(ComandaProdus comandaProdus);
        void Delete(Guid id);
        Task Update(ComandaProdus comandaProdus);
    }
}
