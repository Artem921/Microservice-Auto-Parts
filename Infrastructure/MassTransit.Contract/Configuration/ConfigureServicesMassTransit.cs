using MassTransit.Contract.ViewModels.Product.Request;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MassTransit.Contract.Configuration
{
    public static class ConfigureServicesMassTransit
    {
        public static void ConfigureServices(this IServiceCollection services,IConfiguration configuration,MassTransitConfiguration massTransitConfiguration)
        {
            var rabbitSection = configuration.GetSection("RabbitServer");
            var url = rabbitSection.GetValue<string>("Url");
            var host = rabbitSection.GetValue<string>("Host");
            var name = rabbitSection.GetValue<string>("UserName");
            var password = rabbitSection.GetValue<string>("Password");
       
            services.AddMassTransit(x =>
            {
                x.UsingRabbitMq((context, cfg) =>
                {
                    
                    cfg.Host($"rabbitmq://{url}/{host}", configurator =>
                    {
                        configurator.Username("rabbitAdmin");
                        configurator.Password("server");
                      
                    });
                    cfg.AutoStart = true;
                    cfg.UseMessageRetry(r =>
                    {
                        r.Incremental(3, TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1));
                    });
                    
                    cfg.UseRawJsonSerializer();
                    cfg.ConfigureEndpoints(context, SnakeCaseEndpointNameFormatter.Instance);

                });
            });
        }
    }
}
