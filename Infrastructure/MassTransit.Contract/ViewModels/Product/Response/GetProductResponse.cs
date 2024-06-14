namespace MassTransit.Contract.ViewModels.Product.Response
{
    public record GetProductResponse
    {
        public ProductViewModel Product { get; set; }
    }
}
