


using CarTax.Area.Domain.Repository;
using CarTax.Area.Infrastruchar.Repositories;
using Microsoft.Extensions.DependencyInjection;



namespace CarTax.Area.Infrastruchar.Configurtions.Service
{
    public static class AreaRepositoryServiceConfigure
    {
        public static IServiceCollection AreaRepositoryServiceConfig(this IServiceCollection services)
        {

            services.AddScoped<IAreaRepository, AreasRepository>();

            return services;

        }
    }
}
