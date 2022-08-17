
using FacadeLayer;
using Implimentation;
using Implimentation.Factory;
using Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using Implimentation;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
           

            var serviceProvider = new ServiceCollection()
           .AddFacadeService()
           .BuildServiceProvider();

            var facade = serviceProvider.GetService<IFacade>();
            facade.executeFunction("AFAAS","FSA");

        }
    }
}