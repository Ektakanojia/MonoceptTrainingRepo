namespace ExceptionsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exception Concepts !!");
            int first = int.Parse(args[0]);
            int second = int.Parse(args[1]);
            int result = first / second;
            Console.WriteLine("firstvalue:{0},Secondvalue:{1},ThirdValue:{2}",first,second,result);
            Console.WriteLine("End of main");
            
            Main(args);
        }

        /*
         *Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array. 
         *,line no :8
         *Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.
         *\Program.cs:line 10
         * System.FormatException: Input string was not in a correct format.
         * \Program.cs:line 9
         * System.OverflowException:
         * \Program.cs:line 8
         */
    }
}