using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInheritanceApp
{
    class MotorCycle : Cycle
    {
        public override void Run()
        {
            Console.WriteLine($"{Name}  Runs in the speed of " + (Speed*5));
        }
    }
}
