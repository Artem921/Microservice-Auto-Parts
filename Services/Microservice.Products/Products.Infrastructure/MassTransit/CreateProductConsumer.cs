using Mapster;
using MapsterMapper;
using MassTransit;
using MassTransit.Contract.ViewModels.Product.Request;
using Products.Application.Abstractions;
using Products.Domain.Abstractions;
using Products.Domain.Entities;

namespace Products.Infrastructure.MassTransit
{
    public class CreateProductConsumer :ProductConsumerBase, IConsumer<CreateProductRequest>
    { 
        public CreateProductConsumer(IProductService productsService):base(productsService)
        {
            
        }
        public async Task Consume(ConsumeContext<CreateProductRequest> context)
        {
            var productVM = context.Message.Product;

            var product = productVM.Adapt<Product>();

            await productsService.CreateAsync(product);
        }
    }
}
