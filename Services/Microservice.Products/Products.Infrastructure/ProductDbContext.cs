using Microsoft.EntityFrameworkCore;
using Products.Infrastructure.Configuration;
using Products.Infrastructure.ContextEntities;

namespace Products.Infrastructure
{
    public class ProductDbContext : DbContext
    {
        public DbSet<ProductContext> Products { get; set; }

        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) => Database.Migrate();


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConfigurationDbContext.connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());

        }


    }
}
