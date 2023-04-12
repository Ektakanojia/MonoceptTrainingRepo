using StrategyDesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    internal class Client
    {
        private ICalculate _calculate;
        public Client(ICalculate calculate) 
        {
        _calculate= calculate;
        }
        public int Calculate(int v1,int v2)
        {
            return _calculate.Calculate(v1,v2);
        }
    }
}
