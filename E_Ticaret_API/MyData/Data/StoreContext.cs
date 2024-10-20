using E_Ticaret_API.entities;
using Microsoft.EntityFrameworkCore;

namespace E_Ticaret_API.Data
{
    public class StoreContext:DbContext
    {
        public StoreContext()
        {
        }

        public StoreContext(DbContextOptions options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Product>(r => 
            //r.Property(e=>e.Id).IsRequired()
            
            //);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductBrand> Brand { get; set; }
        public DbSet<ProductType> productTypes { get; set; }
    }
}
