using Implimentation.Factory;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace FacadeLayer
{
    public class Facade : IFacade
    {

        public Facade()
        {

        }

        public void executeFunction(string consumer)
        {
            var services = new ServiceCollection();
            var stepService = services.AddFactoryService();

            var stepFactory = stepService.GetService<IStepFactory>();
            stepFactory.GetSteps(consumer);

        }


    }
}
