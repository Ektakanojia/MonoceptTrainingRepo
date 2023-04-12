using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp.Model
{
    internal class LineItem
    {
        private int _id;
        private string _productName;
        private int _quantatity;
        private double _price;

        public LineItem(int id,string productName,int quantatiy,double price)
        {
            _id= id;
            _productName= productName;
            _quantatity= quantatiy;
            _price= price;
        }
        public double ItemCost
        {
            get; set;
        }
        public int Id
        {
            get { return _id; }
        }
        public string ProductName
        {
            get { return _productName; }
        }

        public double Price
        {
            get { return _price; }
        }
        public int Quantatity
        {
            get { return _quantatity; }
        }
    }
}
