using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderCompostionAggregationApp.Model
{
    public class Order
    {
        private int _count=0;
        private DateTime _dateTime;
        private string _id;
        public List<Lineitem> Items;

       


        public Order(int count, DateTime dateTime, string id, Lineitem lineitem)
        {
            _count = count;
            _dateTime = dateTime;
            _id = id;
             Items= new List<Lineitem>();
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public DateTime CreatedDate
        {
            get;
            set;
        }

        public string Id
        {
            get;set;
        }
        
        public void AddItems(Lineitem lineitems)
        {
             Items.Add(lineitems);
            _count++;
           
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
      
    }
}
