using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces.SwimBehavoir
{
    class Float : SwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("I'm floating!");
        }
    }
}
