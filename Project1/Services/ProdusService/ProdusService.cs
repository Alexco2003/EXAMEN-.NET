using Project1.Data.Models;
using Project1.Repositories.ProdusRepository;
using Project1.Repositories.UtilizatorRepository;

namespace Project1.Services.ProdusService
{
    public class ProdusService: IProdusService
    {
        private readonly IProdusRepository _produsRepository;

        public ProdusService(IProdusRepository produsRepository)
        {
            _produsRepository = produsRepository;
        }

        public async Task<List<Produs>> GetAll()
        {
            return await _produsRepository.GetAllAsync();
        }

        public async Task Create(Produs produs)
        {
            await _produsRepository.CreateAsync(produs);
            await _produsRepository.SaveAsync();
        }

        public void Delete(Guid id)
        {
            _produsRepository.DeleteById(id);
            _produsRepository.SaveAsync();
        }

        public async Task Update(Produs produs)
        {
            _produsRepository.Update(produs);
            await _produsRepository.SaveAsync();
        }
    }
}
