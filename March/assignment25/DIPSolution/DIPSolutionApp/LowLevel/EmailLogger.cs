using DIPSolutionApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolutionApp.LowLevel
{
    internal class EmailLogger : IErrorLogger
    {
        public void Log(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Writng in the file please wait");
            Console.WriteLine(ex.StackTrace);
            Console.ResetColor();
        }
    }
}
