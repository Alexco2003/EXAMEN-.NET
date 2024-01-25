using Project1.Data.Models;
using Project1.Repositories.ComandaRepository;
using Project1.Repositories.UtilizatorRepository;

namespace Project1.Services.ComandaService
{
    public class ComandaService: IComandaService
    {
        private readonly IComandaRepository _comandaRepository;

        public ComandaService(IComandaRepository comandaRepository)
        {
            _comandaRepository = comandaRepository;
        }

        public async Task<List<Comanda>> GetAll()
        {
            return await _comandaRepository.GetAllAsync();
        }

        public async Task Create(Comanda comanda)
        {
            await _comandaRepository.CreateAsync(comanda);
            await _comandaRepository.SaveAsync();
        }

        public void Delete(Guid id)
        {
            _comandaRepository.DeleteById(id);
            _comandaRepository.SaveAsync();
        }

        public async Task Update(Comanda comanda)
        {
            _comandaRepository.Update(comanda);
            await _comandaRepository.SaveAsync();
        }
    }
}
