using SRVoliationApp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SRPRefactorApp.Presentation
{
    internal class InvoicePrinter
    {
        
        public void PrintDetailsToConsole(Invoice invoice)
        {
            Console.ForegroundColor= ConsoleColor.Green;
            string template = $"id: {invoice.Id}" +
                             $"description:{invoice.Description}" +
                             $"cost:{invoice.Cost}" +
                             $"tax amt is :{invoice.CalculateTax()} " +
                             $"{invoice.CalculateDiscount()}";
            Console.WriteLine(template);
            Console.ResetColor();
        }
    }
}
