using Project1.Data.Models;

namespace Project1.Services.UtilizatorService
{
    public interface IUtilizatorService
    {
        Task<List<Utilizator>> GetAll();
        Task Create(Utilizator utilizator);
        void Delete(Guid id);
        Task Update(Utilizator utilizator);
    }
}
