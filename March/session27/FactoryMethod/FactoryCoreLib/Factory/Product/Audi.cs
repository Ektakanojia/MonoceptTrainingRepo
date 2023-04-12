using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCoreLib.Factory.Product
{
    public class Audi : IAutomobile
    {
        public void Start()
        {
            Console.WriteLine("Audi is starting");
        }

        public void Stop()
        {
            Console.WriteLine("Audi is stop");
        }
    }
}
