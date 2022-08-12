using Implimentation.Step;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Implimentation.ContainerBuilder;

namespace Implimentation.Factory
{
    public class FSAStepFactory : IStepFactory
    {
        private readonly IStep _step;
        private readonly IServiceProvider serviceProvider;
        public FSAStepFactory()
        {
           
        }

        public void GetSteps(string consumer)
        {
            switch (consumer)
            {
                case "AFAAS":
                    //  IStep = step1obj
                    //object.execute();

                    break;
                default:
                    break;
            }
        }
    }

}
