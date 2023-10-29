




using Microsoft.Extensions.DependencyInjection;


namespace CarTax.CarType.Application.Configurtions.Service
{
    public static class ServicesConfigurtions
    {
        public static IServiceCollection ApplaicationservicesConfig(this IServiceCollection services)
        {
            services.CarTypeApplicationServiceConfig();
            return services;
        }
    }
}
