using MassTransit.Contract.DTO.Product;

namespace MassTransit.Contract.DTO.Product.Request
{
    public record CreateProductRequest
    {
        public ProductDto Product { get; set; }
    }
}
