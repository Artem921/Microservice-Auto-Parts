using Mapster;
using MapsterMapper;
using MassTransit;
using MassTransit.Contract.DTO.Product;
using MassTransit.Contract.DTO.Product.Request;
using MassTransit.Contract.ViewModels.Product.Response;
using Products.Application.Abstractions;
using Products.Domain.Abstractions;

namespace Products.Infrastructure.MassTransit
{
    public class GetProductByIdConsumer :ProductConsumerBase, IConsumer<GetProductByIdRequest>
    {

        public GetProductByIdConsumer(IProductService productsService) :base(productsService)
        {
          
        }

        public async Task Consume(ConsumeContext<GetProductByIdRequest> context)
        {
            var productId = context.Message.Id;
            var product = productsService.GetByIdAsync(productId);
            var model = product.Adapt<ProductDto>();

            await context.RespondAsync(new GetProductResponse
            {
                Product=model
            });
        }
    }
}
