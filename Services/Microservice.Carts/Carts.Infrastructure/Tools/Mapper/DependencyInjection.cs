﻿using Mapster;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Carts.Infrastructure.Tools.Mapper
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureMapping(this IServiceCollection services)
        {
            var config = TypeAdapterConfig.GlobalSettings;

            Assembly assembly = Assembly.GetExecutingAssembly();
            config.Scan(assembly);

            return services;
        }
    }
}
