using System;
namespace PocOnDelegates
{
    //Declaration
    delegate int OperationOnNumber(int x,int y);
    internal class Program
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Multiply(int x,int y)
        {
            return x * y;
        }
        
        static void Main(string[] args)
        {
            //creating a object of delegate type and passing function as parameter.
            OperationOnNumber operation1 = new OperationOnNumber(Add);
            OperationOnNumber operation2= new OperationOnNumber(Multiply);
            int result1 = operation1(10 , 20);
            Console.WriteLine(result1);
            Console.WriteLine();
            int result2= operation2(10 , 20);
            Console.WriteLine(result2);

        }
    }
}