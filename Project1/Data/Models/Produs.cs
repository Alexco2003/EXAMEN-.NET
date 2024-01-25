using Project1.Data.Models.Base;

namespace Project1.Data.Models
{
    public class Produs : BaseEntity
    {
        public string? Name { get; set; }

        public int? Price { get; set; }

        // relation

        public ICollection<ComandaProdus> ComandaProduse { get; set; }
    }
}
