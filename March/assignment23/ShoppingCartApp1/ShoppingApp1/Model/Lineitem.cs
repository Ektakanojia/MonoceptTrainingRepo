using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderCompostionAggregationApp.Model
{
    public class Lineitem
    {
       

        private string _id;
       
        private int _quantity;

        private Product _product;
        public Lineitem(string id, int quantity, Product product) 
        { 
        _id= id;
        _quantity= quantity;
        _product = product;
        }
        public string Id { get { return _id; } }

        public int Quantatiy
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        public Product Product
        {
            get { return _product; }
        }

        public double CalculateItemCost()
        {
            return (Product.CalculatePriceAfterDiscount() * Quantatiy);
        }

        public override string ToString()
        {
            return "Id:"+Id+"Quantity:"+Quantatiy+"itemcost:"+CalculateItemCost();
        }
    }
}
