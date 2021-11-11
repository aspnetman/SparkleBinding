using System;
using Microsoft.Extensions.DependencyInjection;

namespace SparkleBindingSample.Configuration.DI
{
    public static class ServiceCollectionFactory
    {
        public static ServiceProvider SetupServices(Action<IServiceCollection> addPlatformServices)
        {
            ServiceCollection services = new();

            addPlatformServices?.Invoke(services);

            return services.BuildServiceProvider();
        }
    }
}