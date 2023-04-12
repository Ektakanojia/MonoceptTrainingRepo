using System;


namespace ExampleOfTryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string num = "a";
            int parseVal;
            Console.WriteLine(int.TryParse(num, out parseVal));
            Console.WriteLine(parseVal);
        }
    }
}
