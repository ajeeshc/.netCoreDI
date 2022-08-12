using Interfaces;
using System;


namespace Implimentation.Step
{
    public class Step2 : IStep
    {
        public string StepKey => "Step2";
        void IStep.executer()
        {
            Console.WriteLine("Step1 executed");
        }
    }
}
