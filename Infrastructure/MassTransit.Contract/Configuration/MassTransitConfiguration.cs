using MassTransit.ExtensionsDependencyInjectionIntegration;

namespace MassTransit.Contract.Configuration
{
    public class MassTransitConfiguration
    {
        public Action<IServiceCollectionBusConfigurator> Configuration { get; set; }
    }
}
