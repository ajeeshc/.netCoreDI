using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IStep
    {
        string StepKey { get;}
        void executer();
    }
}
