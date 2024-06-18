using Carts.Domain.Entities;
using Carts.Infrastructure.Entities;
using Mapster;
using MassTransit.Contract.ViewModels.Cart;
using MassTransit.Contract.ViewModels.Product;


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
