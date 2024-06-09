using Mapster;
using Products.Domain.Entities;
using Products.Infrastructure.Configuration.ContextEntities;
namespace Products.Infrastructure.Tools.Mapper
{
    public class RegisterMapper : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<ProductContext, Product>()
                .RequireDestinationMemberSource(true);
        }
    }
}
