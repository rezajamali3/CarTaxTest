
using Library_EF;
using Microsoft.Extensions.DependencyInjection;


namespace TaxCar.Publicholidays.Infrastruchar.Configurtions.Service
{
    public static class UnitOfWorkServiceConfigurtion
    {
        public static IServiceCollection UnitOfWorkServiceConfig(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, TaxCar.Publicholidays.Infrastruchar.UnitOfWork>();
            return services;
        }
    }
}
