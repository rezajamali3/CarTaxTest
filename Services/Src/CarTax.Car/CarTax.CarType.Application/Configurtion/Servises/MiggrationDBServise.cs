using CarTax.CarType.Infrastruchar;
using CarTax.CarType.Infrastruchar.Configurtions.Service;
using Microsoft.Extensions.DependencyInjection;
using Polly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.CarType.Application.Configurtion.Servises
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
