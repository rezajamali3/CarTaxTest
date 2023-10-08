using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Polly;

namespace Cartax.Presentation.Configurtions
{
    public static class PersistenceMigrateDatabaserConfigure
    {

        public static IServiceProvider MigrateDatabase(this IServiceProvider webApp)
        {
            using (var scope = webApp.CreateScope())
            {
                using (var appContext = scope.ServiceProvider.GetRequiredService<CarTaxContext>())
                {
                    var retry = Policy.Handle<Exception>().WaitAndRetry(new[]
                    {

                       TimeSpan.FromSeconds(5),
                       TimeSpan.FromSeconds(10),
                       TimeSpan.FromSeconds(15),});

                    retry.Execute(() =>
                    {

                        bool areMigrationsPending = appContext.AreMigrationsPending();
                        bool hasMigrationsApplied = appContext.HasMigrationsApplied();

                        if (!areMigrationsPending)
                        {
                            appContext.Database.Migrate();
                            Console.WriteLine("There are pending migrations.");
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
            }
            return webApp;
        }

    }
}
