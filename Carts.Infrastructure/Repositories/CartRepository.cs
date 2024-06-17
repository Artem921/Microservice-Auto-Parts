using Carts.Domain.Abstractions;
using Carts.Domain.Entities;

namespace Carts.Infrastructure.Repositories
{
    public class CartRepository : ICartRepository
    {
        public Task CreateAsync(Cart cart)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<Cart>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Cart> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Cart cart)
        {
            throw new NotImplementedException();
        }
    }
}
