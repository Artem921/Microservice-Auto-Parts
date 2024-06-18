using MassTransit.Contract.ViewModels.Product;

namespace MassTransit.Contract.ViewModels.Cart
{
    public class CartDto
    {
        public Guid Id { get; set; }

        public ICollection<ProductDto> Products { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
