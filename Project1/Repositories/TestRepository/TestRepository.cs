using Project1.Data.Models;
using Project1.Data;
using Project1.Repositories.GenericRepository;

namespace Project1.Repositories.TestRepository
{
    public class TestRepository : GenericRepository<TestModel>, ITestRepository
    {
        public TestRepository(ExamenContext dbContext) : base(dbContext) { }
    }
}
