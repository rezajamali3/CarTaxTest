


using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TaxCar.Publicholidays.Infrastruchar;

namespace CarTax.Publicholidays.Infrastruchar.Configurtions.Service
{
    public static class PublicholidayContextServesesConfigure
    {

        public static IServiceCollection DBContextServesiesConfigure
            (
            this IServiceCollection services,
                 IConfiguration configuration 
            )
        {
            services.AddDbContext<PublicholidayDBContext>(
                option
                =>
                {


                    option.UseSqlServer( configuration.GetConnectionString("Publicholiday_ConnectionsStrings"),
                        settings =>  settings.EnableRetryOnFailure() .CommandTimeout(60));

                     option.EnableSensitiveDataLogging(true);

                }
            );

            return services;
        }

    }
}
