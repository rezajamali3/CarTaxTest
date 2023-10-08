<<<<<<< HEAD
﻿

=======
﻿using Cartax.Domain.Entites.Areas;
using Cartax.Domain.Entites.Cars;
using Cartax.Domain.Entites.CarTypes;
using Cartax.Domain.Entites.Citys;
>>>>>>> 6e0109040902ca67597d3488cf835a7f8636c8fb
using Cartax.Domain.Entites.Tax.TaxCars;
using Cartax.Domain.Entites.Tax.TaxWeekDays;
using Cartax.Domain.Entites.Tax.TaxLimitDays;
using Cartax.Domain.Entites.Tax.TaxLimitMoneyDays;
using Cartax.Domain.Entites.Tax.TaxLimitTimes;
using Cartax.Domain.Entites.Tax.TaxLongTerms;
using Cartax.Domain.Entites.Tax.TaxPublicholidays;

using Cartax.Presentation.Base;
using Cartax.Presentation.Data.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cartax.Applications.Interfaces;
using Cartax.Applications.Persistence.Repositories;
using Cartax.Applications.Base;

namespace Cartax.Presentation.Configurtions
{
    public static class PersistenceBaseAllRepositoryDatabaserConfigure
    {
        public static IServiceCollection BaseAllRepositoryDatabaserConfigure(this IServiceCollection services)
        {
            

            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
<<<<<<< HEAD
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
=======


            services.AddScoped<IAreaRipository, AreaRepository>();
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<ICarTypesRepository, CarTaypsRepository>();
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<ITaxCarRepository, TaxCarRepository > ();
            services.AddScoped<ITaxLimitDayRepository , TaxLimitDayRepository > ();
            services.AddScoped<ITaxLimitTimeRepository, TaxLimitTimeRepository > ();
            services.AddScoped<ITaxPublicholidayRepository, TaxPublicholidayRepository>();
            services.AddScoped<ITaxTaxLongTermRepository, TaxTaxLongTermRepository>();
            services.AddScoped<ITaxTimeRepository, TaxTimeRepository > ();
            services.AddScoped<ITaxWeekDayRepository, TaxWeekDayRepository > ();

            services.AddScoped<ITaxLimitMoneyDayRepository, TaxLimitMoneyDayRepository>();
>>>>>>> 6e0109040902ca67597d3488cf835a7f8636c8fb

            return services;
        }
    }
}
