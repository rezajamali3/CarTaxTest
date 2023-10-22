

using Microsoft.Extensions.DependencyInjection;
using Polly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaxCar.Publicholidays.Infrastruchar.Configurtions.Service;

namespace TaxCar.Publicholidays.Application.Configurtion.Servises
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
