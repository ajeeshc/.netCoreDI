using Interfaces;
using System;


namespace Implimentation.Step
{
    public class Step1 : IStep
    {
        void IStep.executer()
        {
            Console.WriteLine("Step1 executed");
        }
    }
} 
