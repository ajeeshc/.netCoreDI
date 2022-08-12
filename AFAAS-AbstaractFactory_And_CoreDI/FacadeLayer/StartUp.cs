using Implimentation.Factory;
using Implimentation.Step;
using Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeLayer
{
    public static class StartUp
    {
        public static IServiceProvider AddFactoryService(this IServiceCollection services)
        {
            services.AddScoped<IStepFactory, FSAStepFactory>();
            return services.BuildServiceProvider();
        }
    }
}
