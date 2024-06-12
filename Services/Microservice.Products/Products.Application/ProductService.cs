using Products.Application.Abstractions;
using Products.Domain.Abstractions;
using Products.Domain.Entities;

namespace Products.Application
{
    public class ProductService : IProductService
    {
        private readonly IProductsRepository productsRepository;

        public ProductService(IProductsRepository productsRepository)
        {
            this.productsRepository = productsRepository;
        }

        public async Task CreateAsync(Product product)
        {
            await productsRepository.CreateAsync(product);
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
