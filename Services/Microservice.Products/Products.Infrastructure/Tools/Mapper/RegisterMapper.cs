using Mapster;
using MassTransit.Contract.DTO.Product;
using Products.Domain.Entities;
using Products.Infrastructure.ContextEntities;
namespace Products.Infrastructure.Tools.Mapper
{
    public class RegisterMapper : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<ProductContext, Product>()
                .RequireDestinationMemberSource(true);

            config.NewConfig<ProductDto, Product>()
                .RequireDestinationMemberSource(true);
        }
    }
}
