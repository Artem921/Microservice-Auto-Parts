using Carts.Domain.Entities;
using Carts.Infrastructure.Entities;
using Mapster;
using MassTransit.Contract.DTO.Cart;


namespace Products.Infrastructure.Tools.Mapper
{
    public class RegisterMapper : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<CartContext, Cart>()
                .RequireDestinationMemberSource(true);

            config.NewConfig<CartDto, Cart>()
                .RequireDestinationMemberSource(true);
        }
    }
}
