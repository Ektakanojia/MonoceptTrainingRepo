using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderCompostionAggregationApp.Model
{
    public class Order
    {
        
        private readonly DateTime _dateTime;
        public List<Lineitem> _items;

        public Order()
        {
           _dateTime= DateTime.Now;
           _items= new List<Lineitem>();
        }

       
        public List<Lineitem>Items
        {
            get
            {
                return _items;
            }
        }
        public DateTime CreatedDate
        {
            get
            {
                return _dateTime;
            }
            
        }  
        public void AddItems(Lineitem lineitems)
        {
             
             _items.Add(lineitems);
        }
        public double CheckoutPrice()
        {
            double checkOutPrice = 0;
            foreach (Lineitem lineitem in Items)
            {
                checkOutPrice += lineitem.CalculateItemCost();
            }
             return checkOutPrice;
        }
        public override string ToString()
        {
            
            string orderDetails = $"Ordered Date Time :{_dateTime} \n";
            double totalprice = 0;
            foreach (Lineitem lineitem in _items)
            {
                totalprice+= lineitem.CalculateItemCost();
                orderDetails+= lineitem.ToString();
                orderDetails += "\n";
            }
            orderDetails += $"Total Billing amount :{totalprice}";
            return orderDetails;
        }
    }
}
