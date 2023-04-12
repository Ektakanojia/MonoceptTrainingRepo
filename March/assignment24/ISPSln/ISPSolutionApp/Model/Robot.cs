using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSolutionApp.Model
{
    internal class Robot : IWalkAble
    {
        public void StartWork()
        {
            Console.WriteLine("Robat start work");
        }

        public void StopWork()
        {
            Console.WriteLine("Robat stop work");
        }
    }
}
