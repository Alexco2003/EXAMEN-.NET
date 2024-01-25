using Project1.Data.Models.Base;

namespace Project1.Data.Models
{
    public class Comanda: BaseEntity
    {
        public string? Name { get; set; }

        // relation
        public Utilizator Utilizator { get; set; }

        public Guid UtilizatorId { get; set; }

        // relation2

        public ICollection<ComandaProdus> ComandaProduse { get; set; }


    }
}
