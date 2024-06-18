using MassTransit.Contract.DTO.Product;

namespace MassTransit.Contract.DTO.Product.Response
{
    public record GetProductResponse
    {
        public ProductDto Product { get; set; }
    }
}
