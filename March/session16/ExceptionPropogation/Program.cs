namespace ExceptionPropogation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inside of main");
            try
            {
                F1();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToUpper());
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine(ex.StackTrace);
                Console.ResetColor();
            }
            Console.WriteLine("End of main");
        }
        private static void F1()
        {
            Console.WriteLine("inside of F1");
            F2();
            Console.WriteLine("end of F1");
        }
        private static void F2()
        {
            Console.WriteLine("inside of F2");
            F3(); 
            Console.WriteLine("end of F2");
        }
        private static void F3()
        {
            Console.WriteLine("inside of F3");
            throw new Exception("something went wrong in F3");
        }
    }
}