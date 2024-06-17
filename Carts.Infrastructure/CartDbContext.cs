using Carts.Domain;
using Carts.Infrastructure.Configuration;
using Carts.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carts.Infrastructure
{
    public class CartDbContext:DbContext
    {
        public DbSet<CartContext> Carts { get; set; }

        public CartDbContext(DbContextOptions<CartDbContext> options) : base(options) => Database.Migrate();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConfigurationDbContext.connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CartConfiguration());

        }
    }
}
