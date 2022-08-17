using Implimentation;
using Implimentation.Factory;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace FacadeLayer
{
    public class Facade : IFacade
    {

        private IAbstractFactory _abstractFactory;
        public Facade(IAbstractFactory abstractFactory)
        {
            _abstractFactory = abstractFactory;
        }

        public void executeFunction(string consumer,string subpractice)
        {
            _abstractFactory.excuteFactory(consumer, subpractice); 
        }


    }
}
