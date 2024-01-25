using Microsoft.EntityFrameworkCore;
using Project1.Data.Models;

namespace Project1.Data
{
        public class ExamenContext : DbContext
        {
            public ExamenContext(DbContextOptions<ExamenContext> options) : base(options) { }

            public DbSet<TestModel> TestModels { get; set; }

        // One to Many
        public DbSet<Utilizator> Utilizatori { get; set; }
        public DbSet<Comanda> Comenzi { get; set; }


        // Many to Many

        public DbSet<Comanda> Comenzi2 { get; set; }
        public DbSet<Produs> Produse { get; set; }
        public DbSet<ComandaProdus> ComandaProduse { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
            // One to Many
            modelBuilder.Entity<Utilizator>()
                        .HasMany(m1 => m1.Comenzi)
                        .WithOne(m2 => m2.Utilizator);

            // Many to Many
            modelBuilder.Entity<ComandaProdus>().HasKey(mr => new { mr.ComandaId, mr.ProdusId });

            // One to many for m-m
            modelBuilder.Entity<ComandaProdus>()
                        .HasOne(mr => mr.Comanda)
                        .WithMany(m3 => m3.ComandaProduse)
                        .HasForeignKey(mr => mr.ComandaId);

            modelBuilder.Entity<ComandaProdus>()
                        .HasOne(mr => mr.Produs)
                        .WithMany(m4 => m4.ComandaProduse)
                        .HasForeignKey(mr => mr.ProdusId);


            base.OnModelCreating(modelBuilder);
            }
        }
    
}
