using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderCompostionAggregationApp.Model
{
    public class Customer
    {
        private string _name;
        private string _id;
        public List<Order> Orders { get; set; }
        public Customer(string name, string id)
        {
            _id = id;
            _name = name;
            Orders = new List<Order>(); 
        }

        public void AddOrders(Order orders)
        {
            Orders.Add(orders);
        }
        public string Name
        {
            get { return _name; }
        }
        public string Id
        {
            get { return _id; }
        }

    }
}
