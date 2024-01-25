using Project1.Data;
using Project1.Data.Models;
using Project1.Repositories.GenericRepository;
using Project1.Repositories.UtilizatorRepository;

namespace Project1.Repositories.ComandaRepository
{
    public class ComandaRepository : GenericRepository<Comanda>, IComandaRepository
    {
        public ComandaRepository(ExamenContext dbContext) : base(dbContext) { }
    }
}
