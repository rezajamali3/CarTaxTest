


using Microsoft.Extensions.DependencyInjection;

using Library_Domain.Interface;
using CarTax.Car.Application.Configurtion.Servises;

namespace TaxCar.Car.Applaication.Configgurtions.Services
{
    public static class ServicesConfigurtions
    {
        public static IServiceCollection ApplaicationservicesConfig(this IServiceCollection services)
        {
            services.AreaApplicationServiceConfig();
            return services;
        }
    }
}
