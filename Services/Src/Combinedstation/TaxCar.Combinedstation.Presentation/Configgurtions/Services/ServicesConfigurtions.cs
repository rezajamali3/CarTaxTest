
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCar.Combinedstation.Application;

namespace TaxCar.Combinedstation.Presentation.Configgurtions.Services
{
    public static class ServicesConfigurtions
    {
        public static IServiceCollection PresentationservicesConfig(this IServiceCollection services)
        {
            return services;
        }
    }
}
