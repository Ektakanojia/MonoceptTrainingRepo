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
        public List<Order> _orders = new List<Order>();
        public Customer(string name, string id, Order order)
        {
            _id = id;
            _name = name;
            _orders.Add(order);
   
        }

        public void AddOrders(Order orders)
        {
            _orders.Add(orders);

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
