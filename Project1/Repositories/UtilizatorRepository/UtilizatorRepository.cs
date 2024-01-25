using Project1.Data;
using Project1.Data.Models;
using Project1.Repositories.GenericRepository;
using Project1.Repositories.TestRepository;

namespace Project1.Repositories.UtilizatorRepository
{
    public class UtilizatorRepository : GenericRepository<Utilizator>, IUtilizatorRepository
    {
        public UtilizatorRepository(ExamenContext dbContext) : base(dbContext) { }
    }
    
}

