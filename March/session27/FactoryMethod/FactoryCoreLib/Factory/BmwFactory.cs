using FactoryCoreLib.Factory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCoreLib.Factory
{
    internal class BmwFactory : IAutomobileFactory
    {
        public IAutomobile Make()
        {
           return new Bmw();
        }
    }
}
