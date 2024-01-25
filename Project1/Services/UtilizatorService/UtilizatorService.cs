using Project1.Data.Models;
using Project1.Repositories.TestRepository;
using Project1.Repositories.UtilizatorRepository;

namespace Project1.Services.UtilizatorService
{
    public class UtilizatorService: IUtilizatorService
    {
        private readonly IUtilizatorRepository _utilizatorRepository;

        public UtilizatorService(IUtilizatorRepository utilizatorRepository)
        {
            _utilizatorRepository = utilizatorRepository;
        }

        public async Task<List<Utilizator>> GetAll()
        {
            return await _utilizatorRepository.GetAllAsync();
        }

        public async Task Create(Utilizator utilizator)
        {
            await _utilizatorRepository.CreateAsync(utilizator);
            await _utilizatorRepository.SaveAsync();
        }

        public void Delete(Guid id)
        {
            _utilizatorRepository.DeleteById(id);
            _utilizatorRepository.SaveAsync();
        }

        public async Task Update(Utilizator utilizator)
        {
            _utilizatorRepository.Update(utilizator);
            await _utilizatorRepository.SaveAsync();
        }
    }
}
