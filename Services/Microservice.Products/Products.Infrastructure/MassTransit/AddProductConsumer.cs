using Mapster;
using MapsterMapper;
using MassTransit;
using MassTransit.Contract.ViewModels.Product.Request;
using Products.Domain.Abstractions;
using Products.Domain.Entities;

namespace Products.Infrastructure.MassTransit
{
    public class AddProductConsumer : IConsumer<AddProductRequest>
    {
        private readonly IProductsRepository productsRepository;
        private readonly IMapper mapper;

        public AddProductConsumer(IMapper mapper, IProductsRepository productsRepository)
        {
            this.mapper = mapper;
            this.productsRepository = productsRepository;
        }
        public async Task Consume(ConsumeContext<AddProductRequest> context)
        {
            var productVM = context.Message.Product;

            var product = productVM.Adapt<Product>();

            await productsRepository.CreateAsync(product);
        }
    }
}
