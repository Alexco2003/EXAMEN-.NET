using System.ComponentModel.DataAnnotations;

namespace Project1.Data.Models.Base
{
    public class BaseEntity : IBaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
