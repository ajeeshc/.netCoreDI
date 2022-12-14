using Implimentation.Step;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implimentation.Factory
{
    public class LCWStepFactory : IStepFactory
    {
        private IEnumerable<IStep> _steps;
        public LCWStepFactory(IEnumerable<IStep> steps)
        {
            _steps = steps;
        }
       
        public void GetSteps(string consumer)
        {
            switch (consumer)
            {
                case "AFAAS":
                    _steps.Where(x => x.StepKey == "Step1").FirstOrDefault().executer();
                    break;
                case "Normal":
                    _steps.First(o => o.GetType() == typeof(Step2)).executer();
                    break;
                default:
                    break;
            }
        }
    }
}
