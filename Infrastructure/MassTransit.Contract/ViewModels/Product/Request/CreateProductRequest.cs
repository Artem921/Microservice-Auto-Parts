namespace MassTransit.Contract.ViewModels.Product.Request
{
    public record CreateProductRequest
    {
        public ProductViewModel Product { get; set; }
    }
}
