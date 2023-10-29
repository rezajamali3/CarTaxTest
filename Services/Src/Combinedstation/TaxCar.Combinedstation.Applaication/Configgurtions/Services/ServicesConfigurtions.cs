

using TaxCar.Combinedstation.Core.Repository;
using CarTax.Combinedstation.Infrastruchar.Repositories;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation;
using TaxCar.Combinedstation.Application;
using Library_Domain.Interface;

namespace TaxCar.Combinedstation.Applaication.Configgurtions.Services
{
    public static class ServicesConfigurtions
    {
        public static IServiceCollection ApplaicationservicesConfig(this IServiceCollection services)
        {

            var assembly = typeof(ServicesConfigurtions).Assembly;

            services.AddMediatR(config => config.RegisterServicesFromAssembly(assembly));

            services.AddValidatorsFromAssembly(assembly);

            services.AddScoped<IApplicationService, CombinedstationApplicationService>();

            services.MassTransitConfig();

            return services;

        }
    }
}
