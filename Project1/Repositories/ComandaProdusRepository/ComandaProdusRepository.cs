using Project1.Data;
using Project1.Data.Models;
using Project1.Repositories.GenericRepository;
using Project1.Repositories.ProdusRepository;

namespace Project1.Repositories.ComandaProdusRepository
{
    public class ComandaProdusRepository : GenericRepository<ComandaProdus>, IComandaProdusRepository
    {
        public ComandaProdusRepository(ExamenContext dbContext) : base(dbContext) { }
    }
}
