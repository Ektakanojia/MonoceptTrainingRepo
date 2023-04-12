using StrategyDesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    internal class Program
    {
        public static void Main()
        {
            Console.ForegroundColor= ConsoleColor.Green;
            Client minu = new Client(new Minus());
            Console.WriteLine("Minus :" + minu.Calculate(200, 100));
            Console.WriteLine();

            Console.ForegroundColor= ConsoleColor.Blue;
            Client plus = new Client(new Plus());
            Console.WriteLine("Plus :" + plus.Calculate(200, 100));

            Console.ResetColor();
        }
    }
}
