using Project1.Data.Models;

namespace Project1.Services.ProdusService
{
    public interface IProdusService
    {
        Task<List<Produs>> GetAll();
        Task Create(Produs produs);
        void Delete(Guid id);
        Task Update(Produs produs);
    }
}
