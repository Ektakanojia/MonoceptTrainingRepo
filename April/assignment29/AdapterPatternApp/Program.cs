using AdapterPatternApp.Model;
using AdpaterExternalLib;

namespace AdapterPatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
            cart.Add(new HatAdpater(new Hat("Golden", "Golden Permium", 999, .08)));
            cart.Add(new HatAdpater(new Hat("Silver","Silver Permium",888,.08)));
           
            PrintDetails(cart);
        }

        private static void PrintDetails(ShoppingCart cart)
        {
            foreach (var item in cart.Items)
            {
                Console.WriteLine(item.Name());
                Console.WriteLine(item.Price());
                Console.WriteLine();
            }
        }
    }
}