using AutoParts.Domain.Entities;
using AutoParts.Infrastructure.Configuration.ContextEntities;
using Mapster;

namespace AutoParts.Infrastructure.Tools.Mapper
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
