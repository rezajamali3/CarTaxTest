


using CarTax.City.Domain.Repositorys;
using CarTax.City.Infrastruchar.Repositories;
using Microsoft.Extensions.DependencyInjection;



namespace CarTax.City.Infrastruchar.Configurtions.Service
{
    public static class CityRepositoryServiceConfigure
    {
        public static IServiceCollection CityRepositoryServiceConfig(this IServiceCollection services)
        {

            services.AddScoped<ICityRepository, CitysRepository>();

            return services;
        }
    }
}
