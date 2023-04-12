using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderCompostionAggregationApp.Model
{
    public class Lineitem
    {
        public Product Products { get; set; }

        private string _id;
       
        private int _quantity;

        

        public string Id { get { return _id; } }

        public int Quantatiy
        {
            get { return _quantity; }
        }

        public double CalculateItemCost()
        {
            return (Products.CalculatePriceAfterDiscount(Products.Price,Products.DiscountPercentage) * Quantatiy);
        }
    }
}
