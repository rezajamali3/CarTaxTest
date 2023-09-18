using Cartax.Domain.Entites.Areas;
using Cartax.Domain.Entites.Cars;
using Cartax.Domain.Entites.CarTypes;
using Cartax.Domain.Entites.Citys;
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
using Cartax.Applications.Persistence.Repositories;
using Cartax.Applications.Common.Base;

namespace Cartax.Presentation.Configurtions
{
    public static class PersistenceBaseAllRepositoryDatabaserConfigure
    {
        public static IServiceCollection BaseAllRepositoryDatabaserConfigure(this IServiceCollection services)
        {

            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
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

            return services;
        }
    }
}
