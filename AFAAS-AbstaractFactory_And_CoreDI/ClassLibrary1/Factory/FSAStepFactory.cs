using Implimentation.Step;
using Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implimentation.Factory
{
    public class FSAStepFactory :IStepFactory
    {
        public FSAStepFactory()
        {
        }

        public void GetSteps(string consumer)
        {
            var services = new ServiceCollection();

            var stepService = services.AddStepService();
            var _step = stepService.GetServices<IStep>();

            switch (consumer)
            {
                case "AFAAS":
                    _step.Where(x => x.StepKey == "Step1").FirstOrDefault().executer();
                    _step.Where(x => x.StepKey == "Step2").FirstOrDefault().executer();
                    break;
                default:
                    break;
            }
        }
    }

}
