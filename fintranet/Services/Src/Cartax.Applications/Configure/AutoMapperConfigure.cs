﻿using Cartax.Applications.Base;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Cartax.Applications.Configure
{
    public static class AutoMapperConfigure
    {
        public static IServiceCollection AutoMapperApplicationsServeces(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));
            return services;


        }
    }
}
