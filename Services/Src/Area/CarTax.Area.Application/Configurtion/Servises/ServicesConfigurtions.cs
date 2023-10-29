


using Microsoft.Extensions.DependencyInjection;

using Library_Domain.Interface;
using CarTax.Car.Application.Configurtion.Servises;

namespace TaxCar.Area.Applaication.Configgurtions.Services
{
    public static class ServicesConfigurtions
    {
        public static IServiceCollection ApplaicationservicesConfig(this IServiceCollection services)
        {


            services.AreaApplicationServiceConfig()
                
                .MassTransitConfig();
            

            return services;
        }
    }
}
