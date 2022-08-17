using Implimentation.Step;
using Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implimentation.Factory
{
    public class FSAStepFactory : IStepFactory
    {
        private IEnumerable<IStep> _step;
        public FSAStepFactory(IEnumerable<IStep> step)
        {
            _step = step;
        }

        public void GetSteps(string consumer)
        {
            switch (consumer)
            {
                case "AFAAS":
                      _step.Where(x => x.StepKey == "Step1").FirstOrDefault().executer();
                    if(1==1)
                        _step.First(o => o.GetType() == typeof(Step2)).executer();
                        _step.First(o => o.GetType() == typeof(Step2)).executer();
                    break;
                case "Normal":
                    _step.First(o => o.GetType() == typeof(Step2)).executer();
                    break;
                case "PREBES":
                    _step.First(o => o.GetType() == typeof(Step2)).executer();
                    break;
                case "POSTBES":
                    _step.First(o => o.GetType() == typeof(Step2)).executer();
                    break;
                default:
                    break;
            }
        }
    }

}
