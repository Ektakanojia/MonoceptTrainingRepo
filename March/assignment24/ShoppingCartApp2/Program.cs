using CustomerOrderCompostionAggregationApp.Model;
using ShoppingCartApp.Model;

namespace ShoppingCartApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product book = new Product("101", "Classmate", 90, 5);
            Product pen = new Product("102", "pentonic", 100, 6);
            Product box = new Product("103", "park", 200, 2);

            Lineitem lineitem1 = new Lineitem("101", 2, book); 
            Lineitem lineitem2 = new Lineitem("102", 3, pen);
            Lineitem lineitem3 = new Lineitem("103", 1, box);
           
            Order order1 = new Order();
            order1.AddItems(lineitem1);
            order1.AddItems(lineitem2);
            order1.AddItems(lineitem3);
            
            //Adding item that aleardy exist in the list
            order1.AddItems(lineitem1);
            order1.AddItems(lineitem3);
            Customer ekta = new Customer("Ekta", "1001", order1);
            PrintInvoice printInvoice = new PrintInvoice();
            printInvoice.PrintOrderDetails(ekta);
            
        }
    }
}