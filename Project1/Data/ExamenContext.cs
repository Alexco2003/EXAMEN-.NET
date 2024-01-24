using Microsoft.EntityFrameworkCore;
using Project1.Data.Models;

namespace Project1.Data
{
        public class ExamenContext : DbContext
        {
            public ExamenContext(DbContextOptions<ExamenContext> options) : base(options) { }

            public DbSet<TestModel> TestModels { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
            }
        }
    
}
