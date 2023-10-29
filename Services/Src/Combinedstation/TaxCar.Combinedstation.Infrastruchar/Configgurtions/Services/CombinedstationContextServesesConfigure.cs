

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using TaxCar.Combinedstation.Infrastruchar;

namespace TaxCar.Combinedstation.Infrastruchar.Configurtions.Services
{
    public static class CombinedstationContextServesesConfigure
    {

        public static IServiceCollection DBContextServesiesConfigure
            (
            this IServiceCollection services,
                 IConfiguration configuration 
            )
        {
            services.AddDbContext<CombinedstationDBContext>(
                option
                =>
                {

                    option.UseSqlServer( configuration.GetConnectionString("Combinedstation_ConnectionsStrings"),
                        settings =>  settings.EnableRetryOnFailure() .CommandTimeout(60));

                     option.EnableSensitiveDataLogging(true);

                }
            );

            return services;
        }

    }
}
