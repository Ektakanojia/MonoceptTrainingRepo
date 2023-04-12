using DIPVolationApp.HighLevel;

namespace DIPVolationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new TextCalculator(ErrorLogOption.TXT);
            Console.WriteLine(calc.CalculateTax(100, 20));
            Console.WriteLine(calc.CalculateTax(100, 0));

        }
    }
}