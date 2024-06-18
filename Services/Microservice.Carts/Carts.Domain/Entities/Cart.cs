using System.Collections;
using Carts.Domain.Entities.ValueObjects;

namespace Carts.Domain.Entities
{
    public class Cart
    {
        public Guid Id { get; set; }

        public ICollection<ProductCart> products { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
