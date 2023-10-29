using CarTax.Area.Application.Consumer;

using MassTransit;
using Microsoft.Extensions.DependencyInjection;
using Polly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Org.BouncyCastle.Math.EC.ECCurve;


namespace TaxCar.Area.Applaication.Configgurtions.Services
{
    public static class MassTransitConfigurtion
    {
        public static IServiceCollection MassTransitConfig(this IServiceCollection services)
        {

         


            services.AddMassTransit(busConfigurator =>
            {
                var entryAssembly = Assembly.GetExecutingAssembly();
                busConfigurator.AddConsumers(entryAssembly);
                busConfigurator.UsingRabbitMq((context, busFactoryConfigurator) =>
                {
                    //busFactoryConfigurator.Host("rabbitmq", "/", h => { });

                    busFactoryConfigurator.Host(new Uri("rabbitmq://yarsoft:123456qrj@localhost"), h =>
                    {
                        h.Username("yarsoft");
                        h.Password("123456qrjA@");
                    });

                    busFactoryConfigurator.ConfigureEndpoints(context);
                });
            });


         

            return services;

        }
    }
}
