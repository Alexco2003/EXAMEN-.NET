using Project1.Data.Models;
using Project1.Repositories.TestRepository;

namespace Project1.Services.TestService
{
    public class TestService : ITestService
    {
        private readonly ITestRepository _testRepository;

        public TestService(ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }

        public async Task<List<TestModel>> GetAll()
        {
            return await _testRepository.GetAllAsync();
        }

        public async Task Create(TestModel test)
        {
            await _testRepository.CreateAsync(test);
            await _testRepository.SaveAsync();
        }

        public void Delete(Guid id)
        {
            _testRepository.DeleteById(id);
            _testRepository.SaveAsync();
        }

        public async Task Update(TestModel test)
        {
            _testRepository.Update(test);
            await _testRepository.SaveAsync();
        }
    }
}
