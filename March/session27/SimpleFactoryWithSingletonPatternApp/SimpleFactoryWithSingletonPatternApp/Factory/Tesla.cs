using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCoreLib.Factory
{
    internal class Tesla:IAutomobile
    {
        public void Start()
        {
            Console.WriteLine("Tesla is starting");
        }

        public void Stop()
        {
            Console.WriteLine("Tesla is stop");
        }
    }
}
