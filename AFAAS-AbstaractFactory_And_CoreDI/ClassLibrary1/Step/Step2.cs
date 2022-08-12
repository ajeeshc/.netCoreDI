using Interfaces;
using System;


namespace Implimentation.Step
{
    public class Step2 : IStep
    {
        void IStep.executer()
        {
            Console.WriteLine("Step1 executed");
        }
    }
}
