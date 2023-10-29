


using CarTax.Combinedstation.Infrastruchar.Repositories;
using Microsoft.Extensions.DependencyInjection;
using TaxCar.Combinedstation.Core.Repository;

namespace TaxCar.Combinedstation.Infrastruchar.Configurtions.Services
{
    public static class CombinedstationRepositoryServiceConfigure
    {
        public static IServiceCollection CombinedstationRepositoryServiceConfig(this IServiceCollection services)
        {

            services.AddScoped<ICombinedStationRepository, CombinedstationRepository>();

            return services;

        }
    }
}
