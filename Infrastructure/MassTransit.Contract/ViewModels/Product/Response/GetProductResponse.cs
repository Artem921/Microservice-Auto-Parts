namespace MassTransit.Contract.ViewModels.Product.Response
{
    public record GetProductResponse
    {
        public ProductDto Product { get; set; }
    }
}
