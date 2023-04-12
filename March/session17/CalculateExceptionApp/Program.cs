using CalculateExceptionApp.Model;

namespace CalculateExceptionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Calculator calculator = new Calculator(10,20);
            try
            {
                calculator.Add(-10, 20);
            } catch(NegativeNumberNotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("end of main");
        }
    }
}