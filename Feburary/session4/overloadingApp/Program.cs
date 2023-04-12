using System;


namespace overloadingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintDetails(10);
            PrintDetails(20.55);
            PrintDetails(20.55f);
            PrintDetails("Ekta kanojia");
            PrintDetails('a');
            PrintDetails(10 > 5);
        }
        private static void PrintDetails(int input)
        {
            Console.WriteLine("The integer Value is {0},double:{1}" , input,2*input);
        }
        private static void PrintDetails(double input)
        {
            Console.WriteLine("The double Value is {0}" , input);
        }
        private static void PrintDetails(float input)
        {
            Console.WriteLine("The double Value is {0}", input);
        }
        private static void PrintDetails(string input)
        {
            Console.WriteLine("The string Value is {0}", input);
        }
        private static void PrintDetails(char input)
        {
            Console.WriteLine("The character Value is {0},ascii value is {1}", input,(int)input);
        }
        private static void PrintDetails(bool input)
        {
            Console.WriteLine("bool value is {0}", input);
        }



    }
}
