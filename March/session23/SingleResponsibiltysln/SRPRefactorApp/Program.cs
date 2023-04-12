using SRPRefactorApp.Presentation;
using SRVoliationApp.model;

namespace SRPRefactorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1, "Traning Invoice", 100, .50);
            InvoiceHtmlPrinter printer = new InvoiceHtmlPrinter();
            printer.PrintDetailsToHtml(invoice);
        }
    }
}