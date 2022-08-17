using Implimentation.Step;
using Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implimentation.Factory
{
    public class KGWStepFactory : IStepFactory
    {
        private IEnumerable<IStep> _step;
        public KGWStepFactory(IEnumerable<IStep> step)
        {
            _step = step;
        }

        public void GetSteps(string consumer)
        {
            switch (consumer)
            {
                case "AFAAS":
                    _step.Where(x => x.StepKey == "Step1").FirstOrDefault().executer();
                    break;
                case "Normal":
                    _step.Where(x => x.StepKey == "Step2").FirstOrDefault().executer();
                    break;
                default:
                    break;
            }
        }
    }

}
