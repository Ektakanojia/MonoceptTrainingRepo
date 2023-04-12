using DIPSolutionApp.HighLevel;
using DIPSolutionApp.LowLevel;
using DIPSolutionApp.Model;

namespace DIPSolutionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            Console.WriteLine();
            CaseStudy2();
        }

        private static void CaseStudy1()
        {
            var cal = new TaxCalculator(new XMLLogger());
            Console.WriteLine(cal.CalculateTax(10, 2));
            Console.WriteLine(cal.CalculateTax(10, 0));
        }

        private static void CaseStudy2()
        {
            var cal = new TaxCalculator(new EmailLogger());
            Console.WriteLine(cal.CalculateTax(10, 2));
            Console.WriteLine(cal.CalculateTax(10, 0));
        }
    }
}