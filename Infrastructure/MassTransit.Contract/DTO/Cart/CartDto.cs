using MassTransit.Contract.DTO.Product;

namespace MassTransit.Contract.DTO.Cart
{
    public class CartDto
    {
        public Guid Id { get; set; }

        public ICollection<ProductDto> Products { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
