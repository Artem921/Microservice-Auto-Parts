using AutoParts.Domain.Entities;
using AutoParts.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;

namespace AutoParts.Infrastructure
{
    public class AutoPartsDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        public AutoPartsDbContext(DbContextOptions<AutoPartsDbContext> options) : base(options) => Database.Migrate();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }


    }
}
