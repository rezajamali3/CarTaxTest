


using Microsoft.Extensions.DependencyInjection;
using CarTax.City.Infrastruchar.Configurtions.Service;

namespace TaxCar.City.Applaication.Configgurtions.Services
{
    public static class ServicesConfigurtions
    {
        public static IServiceCollection ApplaicationservicesConfig(this IServiceCollection services)
        {
            services.CityApplicationServiceConfig();
            return services;
        }
    }
}
