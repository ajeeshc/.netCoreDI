using Implimentation.Factory;
using Implimentation.Step;
using Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Implimentation
{
    public static class StartUp
    {
        public static IServiceProvider AddStepService(this IServiceCollection services)
        {
            services.AddScoped<IStep, Step1>();
            services.AddScoped<IStep, Step1>();
            return services.BuildServiceProvider();
        }
    }
}

