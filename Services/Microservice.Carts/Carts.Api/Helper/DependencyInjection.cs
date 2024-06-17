using Carts.Application.Abstractions;
using Carts.Application;
using Carts.Domain.Abstractions;
using Carts.Infrastructure.Repositories;
using Carts.Infrastructure;

namespace Carts.Api.Helper
{
    public static class DependencyInjection
    {
        public static void ConfigurationServices(this IServiceCollection Services)
        {
            Services.AddDbContext<CartDbContext>();
            Services.AddScoped<ICartRepository, CartRepository>();
            Services.AddScoped<ICartService, CartService>();
        }
    }
}
