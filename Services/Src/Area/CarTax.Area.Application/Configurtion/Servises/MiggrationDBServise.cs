



using CarTax.Area.Infrastruchar.Configurtions.Service;

namespace CarTax.Car.Application.Configurtion.Servises
{
    public static class MiggrationDBServise 
    {
        public static IServiceProvider MiggrationDatabaseServise(this IServiceProvider webApp)
        {

            webApp.MigrateDatabase();

            return webApp;

        }
    }
}
