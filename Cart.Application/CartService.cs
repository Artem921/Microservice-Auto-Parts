using Carts.Application.Abstractions;
using Carts.Domain.Entities;

namespace Carts.Application
{
    public class CartService : ICartService
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
