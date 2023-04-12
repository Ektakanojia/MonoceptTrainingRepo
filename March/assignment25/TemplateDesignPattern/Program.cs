using TemplateDesignPattern.Model;

namespace TemplateDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor= ConsoleColor.Yellow;   
            OrderProcess netOrder = new NetOrder();
            netOrder.processOrder(true);

            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.Blue;
            OrderProcess storeOrder = new StoreOrder(); 
            storeOrder.processOrder(true);

            Console.ResetColor();

        }
    }
}