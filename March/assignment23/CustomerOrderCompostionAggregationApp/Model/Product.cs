using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderCompostionAggregationApp.Model
{
    public class Product
    {
        private double _discountPercentage;
        private string _id;
        private string _name;
        private double _price;

      
        public Product(string id, string name, double price, double discountPercentage)
        {
            _id = id;
            _name = name;
            _price = price;
            _discountPercentage = discountPercentage;
        }
        public double DiscountPercentage { get { return _discountPercentage; } }
        public string Id { get { return _id; } }
        public string Name { get { return _name; } }

        public double Price { get { return _price; } }

       
        public double CalculatePriceAfterDiscount(double price,double discountPercentage)
        {
            return (discountPercentage * price);
        }
    }
}
