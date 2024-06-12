using MassTransit.ExtensionsDependencyInjectionIntegration;

namespace MassTransit.Contract.Configuration
{
    public class MassTransitConfiguration
    {
        public Action<IServiceCollectionBusConfigurator> Configuration { get; set; }

        public Action<IBusControl> BusController { get; set; }

        public string ServiceName { get; set; }

    }
}
