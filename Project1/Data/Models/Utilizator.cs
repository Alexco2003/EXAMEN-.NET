using Project1.Data.Models.Base;

namespace Project1.Data.Models
{
    public class Utilizator: BaseEntity
    {
        public string? Name { get; set; }

        public int? Age { get; set; }

        // relation 
        public ICollection<Comanda>? Comenzi { get; set; }

    }
}
