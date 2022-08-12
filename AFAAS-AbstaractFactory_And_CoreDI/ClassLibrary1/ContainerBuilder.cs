﻿using Implimentation.Factory;
using Implimentation.Step;
using Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace Implimentation
{
    public class ContainerBuilder
    {
        public delegate IStep StepeResolver(string key);
        public delegate IStepFactory FactoryResolver(string key);
        public void Build()
        {
            ServiceCollection container = new ServiceCollection();
            container.AddScoped<FSAStepFactory>();
            container.AddSingleton<IStep, Step1>();
            container.AddSingleton<IStep, Step2>();
        }

        public void getConfiguration()
        {
            ServiceCollection services = new ServiceCollection();

            services.AddTransient<Func<StepS, IStep>>(provider => type =>
            {
                switch (type)
                {
                    case StepS.STEP1:
                        return provider.GetRequiredService<Step1>();
                    case StepS.STEP2:
                        return provider.GetRequiredService<Step2>();
                    case StepS.STEP3:
                        return provider.GetRequiredService<Step2>();
                    default:
                        return provider.GetRequiredService<Step1>();
                }
            });
        }
    }

 

    public enum StepS
    {
        STEP1,
        STEP2,
        STEP3,
        STEP4,
        STEP5
    }
}
