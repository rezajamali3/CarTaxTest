


using Microsoft.Extensions.DependencyInjection;


namespace TaxCar.Publicholidays.Application.Configurtion.Servises
{
    public static class ServicesConfigurtions
    {
        public static IServiceCollection ApplaicationservicesConfig(this IServiceCollection services)
        {
            services.PublicholidayApplicationServiceConfig();
            return services;
        }
    }
}
