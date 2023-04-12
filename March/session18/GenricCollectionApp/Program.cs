using CollectionApp.Model;
using System;
using System.Collections;
using System.Collections.Generic;

namespace GenricCollectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //List<LineItem> dmartCart = new List<LineItem>();
            LineItem[] DynamicArray = { new LineItem(1, "MilkBiki", 2, 50) };
            
            //dmartcart.add(new lineitem(1, "milkbiki", 2, 50));
            //dmartcart.add(new lineitem(2, "dairymilk", 1, 100));
            //dmartcart.add(new lineitem(3, "book", 3, 100));
            // dmartCart.Add("Ekta");
            foreach(LineItem item in dmartCart)
            {
                Console.WriteLine(item.ProductName);
                Console.WriteLine("\t"+item.ItemCost);
            }
            PrintBill(dmartCart);
        }

       
        private static void PrintBill(List<LineItem> dmartCart)
        {
            foreach(LineItem item in dmartCart)
            {
                List<LineItem> list = new List<LineItem>();

                Console.WriteLine(item.ProductName + ":" + item.Price + " * " + item.Quantatity);
                Console.WriteLine(item.Price * item.Quantatity);
            }

            

          

        }
    }
}