using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCoreLib.Factory
{
    internal class Bmw:IAutomobile
    {
        public void Start()
        {
            Console.WriteLine("BMW is starting");
        }

        public void Stop()
        {
            Console.WriteLine("BMW is stop");
        }
    }
}
