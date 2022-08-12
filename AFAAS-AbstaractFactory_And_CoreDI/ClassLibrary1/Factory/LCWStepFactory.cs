using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Implimentation.Factory
{
    public class LCWStepFactory : IStepFactory
    {
        private Func<StepS, IStep> _steps;
        public LCWStepFactory(Func<StepS, IStep> steps)
        {
            _steps = steps;
        }
       
        public void GetSteps(string consumer)
        {
            switch (consumer)
            {
                case "AFAAS":
                    _steps(StepS.STEP1).executer();
                    _steps(StepS.STEP2).executer();
                    break;
                default:
                    break;
            }
        }
    }
}
