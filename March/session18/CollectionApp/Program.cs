using CollectionApp.Model;
using System;
using System.Collections;

namespace CollectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList dmartCart = new ArrayList();
            dmartCart.Add(new LineItem(1, "MilkBiki", 50, 2));
            dmartCart.Add(new LineItem(2, "DairyMilk", 100, 1));
            dmartCart.Add(new LineItem(3, "Book", 100, 3));
            // dmartCart.Add("Ekta");

            /*foreach(object item in dmartCart)
            {
                LineItem lineItem= (LineItem)item;
                Console.WriteLine(lineItem.Id);
                Console.WriteLine(lineItem.ProductName);
                Console.WriteLine(lineItem.Quantatity);
                Console.WriteLine(lineItem.Price);
                /*LineItem lineItem = item as LineItem;
                if(lineItem != null)
                {
                    Console.WriteLine(lineItem.ProductName);
                }
            }*/
            PrintBill(dmartCart);

        }

        private static void PrintBill(ArrayList dmartCart)
        {
            foreach (object item in dmartCart)
            {
                LineItem lineItem = (LineItem)item;
                //Console.WriteLine(lineItem.ProductName);
                //Console.WriteLine(lineItem.Price);
                //Console.WriteLine(lineItem.Quantatity);
              

                Console.WriteLine(lineItem.ProductName +":"+lineItem.Price+" * "+lineItem.Quantatity);
                Console.WriteLine(lineItem.Price * lineItem.Quantatity);



            }
        }
    }
}