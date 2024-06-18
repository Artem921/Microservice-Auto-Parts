namespace MassTransit.Contract.ViewModels.Product.Request
{
    public record CreateProductRequest
    {
        public ProductDto Product { get; set; }
    }
}
