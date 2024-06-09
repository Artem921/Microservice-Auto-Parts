using Microsoft.EntityFrameworkCore;
using Products.Infrastructure.Configuration;
using Products.Infrastructure.Configuration.ContextEntities;

namespace Products.Infrastructure
{
    public class AutoPartsDbContext : DbContext
    {
        public DbSet<ProductContext> Products { get; set; }

        public AutoPartsDbContext(DbContextOptions<AutoPartsDbContext> options) : base(options) => Database.Migrate();


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
