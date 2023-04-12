using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPVolationApp.LowLevel
{
    internal class TXTErrorLogger
    {
        public void Log(Exception exception) 
        { 
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Writng in the file please wait");
        Console.WriteLine(exception.StackTrace);
        Console.ResetColor();
        
        }
    }
}
