﻿
using Cartax.Presentation.Base;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarTax.Car.Infrastruchar.Configurtions.Service
{
    public static class BaseAllRepositoryDatabaserConfigure
    {
        public static IServiceCollection AllRepositoryDatabaserConfigure(this IServiceCollection services)
        {

            //services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
            //services.AddScoped<IAreaRipository, AreaRepository>();
            //services.AddScoped<ICarRepository, CarRepository>();
            //services.AddScoped<ICarTypesRepository, CarTaypsRepository>();
            //services.AddScoped<ICityRepository, CityRepository>();
            //services.AddScoped<ITaxCarRepository, TaxCarRepository > ();
            //services.AddScoped<ITaxLimitDayRepository , TaxLimitDayRepository > ();
            //services.AddScoped<ITaxLimitTimeRepository, TaxLimitTimeRepository > ();
            //services.AddScoped<ITaxPublicholidayRepository, TaxPublicholidayRepository>();
            //services.AddScoped<ITaxTaxLongTermRepository, TaxTaxLongTermRepository>();
            //services.AddScoped<ITaxTimeRepository, TaxTimeRepository > ();
            //services.AddScoped<ITaxWeekDayRepository, TaxWeekDayRepository > ();
            //services.AddScoped<ITaxLimitMoneyDayRepository, TaxLimitMoneyDayRepository>();

            return services;
        }
    }
}