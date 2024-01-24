using Project1.Data.Models;

namespace Project1.Services.TestService
{
    public interface ITestService
    {
        Task<List<TestModel>> GetAll();
        Task Create(TestModel test);
        void Delete(Guid id);
        Task Update(TestModel test);
    }
}
