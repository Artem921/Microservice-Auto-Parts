using AutoParts.Infrastructure.Configuration;
using AutoParts.Infrastructure.Configuration.ContextEntities;
using Microsoft.EntityFrameworkCore;

namespace AutoParts.Infrastructure
{
    public class AutoPartsDbContext:DbContext
    {
        public DbSet<ProductContext> Products { get; set; }

        public AutoPartsDbContext(DbContextOptions<AutoPartsDbContext> options) : base(options) => Database.Migrate();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }


    }
}
