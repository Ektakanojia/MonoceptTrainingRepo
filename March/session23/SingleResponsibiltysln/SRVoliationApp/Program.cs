using SRVoliationApp.model;

namespace SRVoliationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1, "Traning Invoice", 100, .50);
            invoice.PrintDetails();
        }
    }
}