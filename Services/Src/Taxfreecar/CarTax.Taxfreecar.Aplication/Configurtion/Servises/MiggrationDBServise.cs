
using CarTax.Taxfreecar.Infrastruchar.Configurtions.Service;


namespace CarTax.Taxfreecar.Aplication.Configurtion.Servises
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
