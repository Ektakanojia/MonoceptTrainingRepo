using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Model
{
    internal class Plus : ICalculate
    {
        public int Calculate(int num1, int num2)
        {
           return num1+num2;
        }
    }
}
