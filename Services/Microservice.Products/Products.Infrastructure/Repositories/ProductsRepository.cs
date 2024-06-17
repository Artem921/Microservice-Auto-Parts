using Mapster;
using Microsoft.EntityFrameworkCore;
using Products.Domain.Abstractions;
using Products.Domain.Entities;
using Products.Infrastructure.ContextEntities;

namespace Products.Infrastructure.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly ProductDbContext context;

        public ProductsRepository(ProductDbContext context)
        {
            this.context = context;

        }

        public async Task CreateAsync(Product product)
        {
            var productContext = product.Adapt<ProductContext>();

            await context.Products.AddAsync(productContext);

            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Product product)
        {
            await context.Products
                .Where(p => p.Id == product.Id)
                .ExecuteUpdateAsync(s => s
                .SetProperty(b => b.Id, b => product.Id)
                .SetProperty(b => b.Description, b => product.Description)
                .SetProperty(b => b.InStock, b => product.InStock)
                .SetProperty(b => b.State, b => product.State)
                .SetProperty(b => b.Name, b => product.Name)
                .SetProperty(b => b.VendorName, b => product.VendorName)
                .SetProperty(b => b.DateArrival, b => product.DateArrival)
                .SetProperty(b => b.Articul, b => product.Articul)
                .SetProperty(b => b.Manufacture, b => product.Manufacture)
                .SetProperty(b => b.Price, b => product.Price));

            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            await context.Products
                .Where(p => p.Id == id)
                .ExecuteDeleteAsync();

            await context.SaveChangesAsync();
        }

        public async Task<IReadOnlyCollection<Product>> GetAllAsync()
        {
            var products = await context.Products.ToListAsync();

            return products.Adapt<IReadOnlyCollection<Product>>();
        }

        public async Task<Product> GetByIdAsync(Guid id)
        {
            var product = await context.Products.FirstOrDefaultAsync(p => p.Id == id);

            return product.Adapt<Product>();
        }

    }
}
