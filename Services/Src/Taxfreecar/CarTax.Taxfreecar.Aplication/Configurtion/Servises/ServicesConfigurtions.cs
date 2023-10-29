




using CarTax.Taxfreecar.Aplication.Configurtion.Servises;
using Microsoft.Extensions.DependencyInjection;


namespace CarTax.Taxfreecar.Application.Configurtions.Service
{
    public static class ServicesConfigurtions
    {
        public static IServiceCollection ApplaicationservicesConfig(this IServiceCollection services)
        {
            services.TaxfreecarApplicationServiceConfig();
            return services;
        }
    }
}
