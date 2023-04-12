using PocOnFacadeDesignPattern.Model;

namespace PocOnFacadeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n....................Order for Maggie............\n");
            RestrauntFacade restrauntFacade = new RestrauntFacade();
            restrauntFacade.GetPlainMaggie();
            Console.WriteLine();
            Console.WriteLine("\n.....................Order for Tea.............\n");
            restrauntFacade.GetTea();
        }
    }
}