using System;

namespace CommandLineArgApp
{
    internal class Program
    {
        static void Main(string[] argsOfNames)
        {
            Console.WriteLine("Inside main");
            Console.Write(argsOfNames.Length);
            Console.WriteLine("End of Main");
            /*for(int i=0;i<argsOfNames.Length;i++)
            {
                Console.Write("Hello "+ argsOfNames[i]);
            }*/
            foreach(string userName in argsOfNames)
            {
                Console.WriteLine(userName);
            }
        }
        //foreach(string name:)
    }
}
