using CalculatorEventApp.Model;

namespace CalculatorEventApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.OnAdditionCompleted += PrintResult;
            calculator.Add(10, 20);
            calculator.Add(20, 30);

        }

        private static void PrintResult(int num1, int num2, string res)
        {
            Console.WriteLine(res);
        }
    }
}