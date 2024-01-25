using Project1.Data.Models.Base;

namespace Project1.Data.Models
{
    public class ComandaProdus : BaseEntity
    {
        public  string? Name { get; set; }

        // relation
        public Guid ComandaId { get; set; }
        public Comanda Comanda { get; set; }

        public Guid ProdusId { get; set; }
        public Produs Produs { get; set; }
    }
}
