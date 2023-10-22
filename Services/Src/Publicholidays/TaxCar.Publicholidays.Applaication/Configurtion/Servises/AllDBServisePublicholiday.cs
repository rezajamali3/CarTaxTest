


using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TaxCar.Publicholidays.Infrastruchar.Configurtions.Service;

namespace TaxCar.Publicholidays.Application.Configurtion.Servises
{
    public static class AllDBServisePublicholiday
    {
        public static IServiceCollection AllDBServisePublicholidayConfig(
        this IServiceCollection services,
             IConfiguration     configuration )
        {

            services.DBContextServesiesConfigure(configuration)
                    .PublicholidayApplicationServiceConfig()
                    .PublicholidayRepositoryServiceConfig()
                    .UnitOfWorkServiceConfig();


            return services;
        }
    }
}
