using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Dapper
{
    public static class DapperContextConfigurtion
    {
        public static IServiceCollection QueryContextConfig(this IServiceCollection service,string? connectionsStrings)
        {

            service.AddScoped<IDbConnection>(c => new QureyContext(connectionsStrings).CreateConnection());

          

            return service;
        }
    }
}
