using Products.Application.Abstractions;

namespace Products.Infrastructure.MassTransit
{
    public  abstract class ProductConsumerBase
    {
         public readonly IProductService productsService;

        protected ProductConsumerBase(IProductService productsService)
        {
            this.productsService = productsService;
        }
    }
}
