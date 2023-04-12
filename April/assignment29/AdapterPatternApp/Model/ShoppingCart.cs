using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternApp.Model
{
    internal class ShoppingCart
    {
        private List<Item> _items= new List<Item>();

        public void Add(Item item)
        {
            _items.Add(item);
        }

        public void Remove(Item item)
        {
            _items.Remove(item);
        }

        public double TotalPrice(Item item)
        {
            double totalPrice = 0;
           foreach (Item item2 in _items)
            {
                totalPrice += item2.Price();
            }
           return totalPrice;
        }

        public List<Item> Items
        {
            get { return _items; }
        }
    }
}
