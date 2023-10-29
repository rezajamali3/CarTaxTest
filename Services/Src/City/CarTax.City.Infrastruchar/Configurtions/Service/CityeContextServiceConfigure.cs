

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace CarTax.City.Infrastruchar.Configurtions.Service
{
    public static class CityeContextServiceConfigure
    {

        public static IServiceCollection DBContextServesiesConfigure(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<CityDBContext>(
                option =>
                {
                    option.UseSqlServer(configuration.GetConnectionString("City_ConnectionsStrings"),
                        settings => settings.EnableRetryOnFailure().CommandTimeout(60));

                   option.EnableSensitiveDataLogging();
                }
            );

            return services;
        }

    }
}
