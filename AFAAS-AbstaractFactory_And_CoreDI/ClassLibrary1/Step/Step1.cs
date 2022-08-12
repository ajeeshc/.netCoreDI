using Interfaces;
using System;


namespace Implimentation.Step
{
    public class Step1 : IStep
    {
        public string StepKey => "Step1";

        void IStep.executer()
        {
            Console.WriteLine("Step1 executed");
        }
    }
} 
