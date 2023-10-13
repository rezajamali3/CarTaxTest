

using CarTax.Car.Infrastruchar;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Polly;

namespace CarTax.Car.Infrastruchar.Configurtions.Service
{
    public static class MigrateDatabaserConfigure
    {

        public static IServiceProvider MigrateDatabase(this IServiceProvider webApp)
        {
            using (var scope = webApp.CreateScope())
            {

                var appContext = scope.ServiceProvider.GetRequiredService<CarDBContext>();

                var retryPolicy = Policy
                    .Handle<Exception>()
                    .WaitAndRetry(new[]
                    {
                     TimeSpan.FromSeconds(5),
                     TimeSpan.FromSeconds(10),
                     TimeSpan.FromSeconds(15)
                    });

                retryPolicy.Execute(() =>
                {
                  
                    bool areMigrationsPending = appContext.AreMigrationsPending();
                    bool hasMigrationsApplied = appContext.HasMigrationsApplied();

                    if (!areMigrationsPending)
                    {
                        appContext.Database.Migrate();
                    }
                    else if (hasMigrationsApplied)
                    {
                        appContext.Database.EnsureCreated();
                        Console.WriteLine("All migrations have been applied.");
                    }
                    else
                    {
                        Console.WriteLine("No migrations found.");
                    }

                });

            }

            return webApp;

        }

    }
}


