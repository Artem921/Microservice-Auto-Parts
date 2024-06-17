using Carts.Domain.Entities;

namespace Carts.Domain.Abstractions
{
    public interface ICartRepository
    {
        Task<IReadOnlyCollection<Cart>> GetAllAsync();
        Task<Cart> GetByIdAsync(Guid id);
        Task CreateAsync(Cart cart);
        Task DeleteAsync(Guid id);
        Task UpdateAsync(Cart cart);
    }
}
