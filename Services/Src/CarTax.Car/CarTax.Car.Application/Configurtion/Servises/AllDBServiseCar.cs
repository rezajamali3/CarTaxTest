﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarTax.Car.Infrastruchar.Configurtions.Service;
using Microsoft.Extensions.Configuration;

namespace CarTax.Car.Application.Configurtion.Servises
{
    public static class AllDBServiseCar
    {
        public static IServiceCollection AllDBServiseCarConfig(
       this IServiceCollection services,
            IConfiguration     configuration )
        {

            services.DBContextServesiesConfigure(configuration)
                    .CarApplicationServiceConfig()
                    .CarRepositoryServiceConfig()
                    .UnitOfWorkServiceConfig();


            return services;
        }
    }
}
