
using Library_EF;
using Microsoft.Extensions.DependencyInjection;


namespace CarTax.Tax.Infrastruchar.Configurtions.Service
{
    public static class UnitOfWorkServiceConfigurtion
    {
        public static IServiceCollection UnitOfWorkServiceConfig(this IServiceCollection services)
        {

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;

        }
    }
}
