using Mapster;
using MapsterMapper;
using MassTransit;
using MassTransit.Contract.ViewModels.Product;
using MassTransit.Contract.ViewModels.Product.Request;
using Products.Domain.Abstractions;

namespace Products.Infrastructure.MassTransit
{
    public class GetProductByIdConsumer : IConsumer<GetProductByIdRequest>
    {
        private readonly IProductsRepository productsRepository;
        private readonly IMapper mapper;

        public GetProductByIdConsumer(IMapper mapper,IProductsRepository productsRepository)
        {
            this.mapper = mapper;
            this.productsRepository = productsRepository;
        }

        public async Task Consume(ConsumeContext<GetProductByIdRequest> context)
        {
            var productId = context.Message.Id;
            var product = productsRepository.GetByIdAsync(productId);
            var models = product.Adapt<ProductViewModel>();

            await context.RespondAsync(models);
        }
    }
}
