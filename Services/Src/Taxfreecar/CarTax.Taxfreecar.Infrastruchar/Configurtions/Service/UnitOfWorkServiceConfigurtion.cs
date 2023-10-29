
using Library_EF;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.Taxfreecar.Infrastruchar.Configurtions.Service
{
    public static class UnitOfWorkServiceConfigurtion
    {
        public static IServiceCollection UnitOfWorkServiceConfig(this IServiceCollection services)
        {

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
