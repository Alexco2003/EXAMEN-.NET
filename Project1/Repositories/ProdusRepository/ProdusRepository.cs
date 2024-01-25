using Project1.Data;
using Project1.Data.Models;
using Project1.Repositories.GenericRepository;
using Project1.Repositories.UtilizatorRepository;

namespace Project1.Repositories.ProdusRepository
{
    public class ProdusRepository : GenericRepository<Produs>, IProdusRepository
    {
        public ProdusRepository(ExamenContext dbContext) : base(dbContext) { }
    }
}
