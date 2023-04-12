using GuitarInventoryApp.Model;

namespace GuitarInventoryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Guitar guitar = new Guitar("1002",2000,"UP23","m1","b2","SAND","SUN");
            Inventory inventory = new Inventory();
            inventory.AddGuitar("1002", 2000, "UP23", "m1", "b2", "SAND", "SUN");
            Console.WriteLine(inventory.ToString());
          

        }
    }
}