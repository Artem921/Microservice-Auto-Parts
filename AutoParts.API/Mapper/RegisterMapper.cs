using AutoParts.Domain.Entities;
using AutoParts.Infrastructure.Configuration.ContextEntities;
using Mapster;

namespace AutoParts.API.Mapper
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
