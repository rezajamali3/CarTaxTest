

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TaxCar.Tax.Infrastruchar;

namespace CarTax.Tax.Infrastruchar.Configurtions.Service
{
    public static class TaxCarAreaContextServiceConfigure
    {

        public static IServiceCollection DBContextServesiesConfigure(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<TaxCarAreaDBContext>(
                option =>
                {
                    option.UseSqlServer(configuration.GetConnectionString("TaxCarArea_ConnectionsStrings"),
                        settings => settings.EnableRetryOnFailure().CommandTimeout(60));
                   option.EnableSensitiveDataLogging();
                }
            );

            return services;
        }

    }
}
