using Implimentation.Factory;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implimentation
{
    public class AbstractFactory : IAbstractFactory
    {
        //private readonly Func<string, IStepFactory> _factory;
        //public AbstractFactory(Func<string, IStepFactory> factory)
        //{
        //    _factory = factory;
        //}
        private IEnumerable<IStepFactory> _factory;
        public AbstractFactory(IEnumerable<IStepFactory> factory)
        {
            _factory = factory;
        }
        public void excuteFactory(string consumer, string subPractice)
        {
            switch (subPractice)
            {
                case "FSA":
                    _factory.First(o => o.GetType() == typeof(FSAStepFactory)).GetSteps(consumer);
                    break;
                case "LCW":
                    _factory.First(o => o.GetType() == typeof(FSAStepFactory)).GetSteps(consumer);
                    break;
                default:
                    break;
            }
        }
    }
}
