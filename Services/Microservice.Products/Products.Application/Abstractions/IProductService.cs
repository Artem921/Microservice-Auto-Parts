using Products.Domain.Entities;

namespace Products.Application.Abstractions
{
    public interface IProductService
    {
        Task<IReadOnlyCollection<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(Guid id);
        Task CreateAsync(Product product);
        Task DeleteAsync(Guid id);
        Task UpdateAsync(Product product);
    }
}
