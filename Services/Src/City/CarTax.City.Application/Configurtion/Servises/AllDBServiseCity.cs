

using CarTax.City.Infrastruchar.Configurtions.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CarTax.City.Application.Configurtion.Servises
{
    public static class AllDBServiseCity
    {
        public static IServiceCollection AllDBServiseCarTypeConfig(
       this IServiceCollection services,
            IConfiguration     configuration )
        {

            services.DBContextServesiesConfigure(configuration)
                    .CarTypeApplicationServiceConfig()
                    .CarTypeRepositoryServiceConfig()
                    .UnitOfWorkServiceConfig();


            return services;
        }
    }
}
