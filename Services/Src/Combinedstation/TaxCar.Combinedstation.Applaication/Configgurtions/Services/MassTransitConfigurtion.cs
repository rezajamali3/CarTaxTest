using MassTransit;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCar.Combinedstation.Application;

namespace TaxCar.Combinedstation.Applaication.Configgurtions.Services
{
    public static class MassTransitConfigurtion
    {
        public static IServiceCollection MassTransitConfig(this IServiceCollection services)
        {

            var assembly = typeof(ServicesConfigurtions).Assembly;


            services.AddMassTransit(async x =>
            {
                x.SetKebabCaseEndpointNameFormatter();

                x.AddBus(provider => Bus.Factory.CreateUsingRabbitMq(config =>
                {
                 

                        config.Host(new Uri("rabbitmq://yarsoft:123456qrj@localhost"), h =>
                        {
                            h.Username("yarsoft");
                            h.Password("123456qrjA@");
                        });
                    

                }));


            });


            //services.Configure<MassTransitHostOptions>(options =>
            //{
            //    options.WaitUntilStarted = true;
            //    options.StartTimeout = TimeSpan.FromSeconds(30);
            //    options.StopTimeout = TimeSpan.FromMinutes(1);
            //});


            return services;

        }
    }
}
