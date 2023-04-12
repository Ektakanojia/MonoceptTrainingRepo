using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPVolationApp.LowLevel
{
    internal class XMLErrorLog
    {
        public void Log(Exception exception)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Writng in the xml file please wait");
            Console.WriteLine(exception.Message);
            Console.WriteLine(exception.StackTrace);
            Console.ResetColor();

        }
    }
}
