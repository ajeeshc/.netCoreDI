using Implimentation.Factory;
using Implimentation.Step;
using Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Implimentation
{
    public static class StartUp
    {
        public static IServiceCollection AddStepService(this IServiceCollection services)
        {
            services.AddScoped<IStep, Step1>();
            services.AddScoped<IStep, Step2>();
            services.AddScoped<IAbstractFactory, AbstractFactory>();
            services.AddScoped<IStepFactory, FSAStepFactory>();
            services.AddScoped<IStepFactory, LCWStepFactory>();
            services.AddScoped<IStepFactory, KGWStepFactory>();


            services.AddTransient<Func<string, IStepFactory>>(serviceProvider => key =>
            {
                switch (key)
                {
                    case "FSA":
                        return serviceProvider.GetService<FSAStepFactory>();
                    case "LCW":
                        return serviceProvider.GetService<LCWStepFactory>();
                    default:
                        return serviceProvider.GetService<KGWStepFactory>();
                }
            });

            return services;
        }

       
    }
}

