using Project1.Data.Models;
using Project1.Repositories.ComandaProdusRepository;
using Project1.Repositories.ProdusRepository;

namespace Project1.Services.ComandaProdusService
{
    public class ComandaProdusService: IComandaProdusService
    {
        private readonly IComandaProdusRepository _comandaProdusRepository;

        public ComandaProdusService(IComandaProdusRepository comandaProdusRepository)
        {
            _comandaProdusRepository = comandaProdusRepository;
        }

        public async Task<List<ComandaProdus>> GetAll()
        {
            return await _comandaProdusRepository.GetAllAsync();
        }

        public async Task Create(ComandaProdus comandaProdus)
        {
            await _comandaProdusRepository.CreateAsync(comandaProdus);
            await _comandaProdusRepository.SaveAsync();
        }

        public void Delete(Guid id)
        {
            _comandaProdusRepository.DeleteById(id);
            _comandaProdusRepository.SaveAsync();
        }

        public async Task Update(ComandaProdus comandaProdus)
        {
            _comandaProdusRepository.Update(comandaProdus);
            await _comandaProdusRepository.SaveAsync();
        }
    }
}
