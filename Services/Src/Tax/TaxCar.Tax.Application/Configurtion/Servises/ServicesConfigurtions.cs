


using TaxCar.Tax.Application.Configurtion.Servises;
using Microsoft.Extensions.DependencyInjection;


namespace CarTax.Tax.Application.Configurtion.Servises
{
    public static class ServicesConfigurtions
    {
        public static IServiceCollection ApplaicationservicesConfig(this IServiceCollection services)
        {
            services.TaxCarAreaApplicationServiceConfig();
            return services;
        }
    }
}
