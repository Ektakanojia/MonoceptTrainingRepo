using CustomerOrderCompostionAggregationApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp.Model
{
    public class PrintInvoice
    {
        public void PrintOrderDetails(Customer customer )
        {
            Console.WriteLine();
            Console.WriteLine("Customer Name:"+customer.Name);
            Console.WriteLine("Customer Id:"+customer.Id);

            Console.WriteLine("Odered Details");
            int orderCount = 1;
            foreach(var item in customer._orders)
            {
                Console.WriteLine("Order : {0}", orderCount++);
                Console.WriteLine(item.ToString());
            }

        }
    }
}
