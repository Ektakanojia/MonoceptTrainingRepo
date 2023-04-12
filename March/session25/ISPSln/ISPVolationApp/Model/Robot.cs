using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPVolationApp.Model
{
    internal class Robot : IWorker
    {
        public void StartEat()
        {
            Console.WriteLine("Roboat start Eat");
        }

        public void StartWork()
        {
            Console.WriteLine("Roboat start work");
        }

        public void StopEat()
        {
            Console.WriteLine("Roboat stop eat");
        }

        public void StopWork()
        {
            Console.WriteLine("Roboat stop work");
        }
    }
}
