using Carts.Domain.Entities.ValueObjects;

namespace Carts.Infrastructure.Entities
{
    public class CartContext
    {
        public Guid Id { get; set; }

        public List<ProductCart>? Products { get; set; }

        public Guid PersonId { get; set; }
    }
}
