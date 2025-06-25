using Blinko_5_minute.model;
using System.Data.Entity;

namespace Blinko_5_minute.context
{
    public class BlinkoDBContext:DbContext
    {

        public BlinkoDBContext() : base("name=BlinkoDBContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure your entity mappings here
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
                .HasKey(p => p.Sku)
                .Property(p => p.Sku)
                .IsRequired();
        }

        // Define DbSets for your entities
         public DbSet<Product> Products { get; set; }
        // public DbSet<Order> Orders { get; set; }
        // Add other DbSets as needed
    }
}
