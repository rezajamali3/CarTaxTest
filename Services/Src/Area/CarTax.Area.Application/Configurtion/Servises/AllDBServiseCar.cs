using Microsoft.Extensions.DependencyInjection;

using Microsoft.Extensions.Configuration;
using CarTax.Area.Infrastruchar.Configurtions.Service;
using CarTax.Car.Application.Configurtion.Servises;

namespace CarTax.Area.Application.Configurtion.Servises
{
    public static class AllDBServiseCar
    {
        public static IServiceCollection AllDBServiseAreaConfig(
       this IServiceCollection services,
            IConfiguration     configuration )
        {

            services.DBContextServesiesConfigure(configuration)
                    .AreaApplicationServiceConfig()
                    .AreaRepositoryServiceConfig()
                    .UnitOfWorkServiceConfig();


            return services;
        }
    }
}
