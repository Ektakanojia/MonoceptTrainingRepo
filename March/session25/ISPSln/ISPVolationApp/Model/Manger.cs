using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPVolationApp.Model
{
    internal class Manger : IWorker
    {
        public void StartEat()
        {
            Console.WriteLine("Manger start Eat");
        }

        public void StartWork()
        {
            Console.WriteLine("Manger start work");
        }

        public void StopEat()
        {
            Console.WriteLine("Manger stop Eat");
        }

        public void StopWork()
        {
            Console.WriteLine("Manger stop work");
        }
    }
}
