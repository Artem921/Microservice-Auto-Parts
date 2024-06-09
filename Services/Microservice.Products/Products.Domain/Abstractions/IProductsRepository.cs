using Products.Domain.Entities;

namespace Products.Domain.Abstractions
{
    public interface IProductsRepository
    {
        Task<IReadOnlyCollection<Product>> GetAll();
        Task<Product> GetById(Guid id);
        Task Create(Product product);
        Task Delete(Guid id);
        Task Update(Product product);

    }
}
