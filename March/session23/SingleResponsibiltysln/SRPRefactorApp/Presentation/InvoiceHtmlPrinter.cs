using SRVoliationApp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPRefactorApp.Presentation
{
    internal class InvoiceHtmlPrinter
    {
        public void PrintDetailsToHtml(Invoice invoice)
        {
            string template = $"id: {invoice.Id}" +
                             $"description:{invoice.Description}" +
                             $"cost:{invoice.Cost}" +
                             $"tax amt is :{invoice.CalculateTax()} " +
                             $"{invoice.CalculateDiscount()}";

           StreamWriter writer = new StreamWriter(invoice.Id+"html");
            writer.WriteLine("<html>");
            writer.WriteLine("<body>");
            writer.WriteLine("<h1>");
            writer.WriteLine(template);
            writer.WriteLine("</h1>");
            writer.WriteLine("</body>");
            writer.WriteLine("</html>");


            writer.Close();


        }
    }
}
