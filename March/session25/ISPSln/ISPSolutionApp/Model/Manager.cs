using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSolutionApp.Model
{
    internal class Manager : IWalkEat
    {
        public void StartEat()
        {
            Console.WriteLine("Manager start Eat");
        }

        public void StartWork()
        {
            Console.WriteLine("Manger start work");
        }

        public void StopEat()
        {
            Console.WriteLine("Manager stop Eat");  
        }

        public void StopWork()
        {
            Console.WriteLine("Manager stop work");
        }
    }
}
