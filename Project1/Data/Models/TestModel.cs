using System.ComponentModel.DataAnnotations.Schema;
using Project1.Data.Models.Base;

namespace Project1.Data.Models
{
    [Table("TestModels")]
    public class TestModel : BaseEntity
    {
        public string Data { get; set; }
    }
}
