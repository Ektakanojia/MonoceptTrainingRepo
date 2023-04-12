using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarInventoryApp.Model
{
    internal class Guitar
    {
        private string _serialNumber;
        private double _price;
        private string _builder;
        private string _model;
        private string _type;
        private string _backWood;
        private string _topWood;


        public Guitar(string serialNumber,double price,string builder,string model,string type,string backWood,string topWood)
        {
            _serialNumber = serialNumber;
            _price = price;
            _builder = builder;
            _model = model;
            _type = type;
            _backWood = backWood;
            _topWood = topWood;
        } 
       
        public string SerialNumber
        {
            // return _serialNumber;
            get;set;
        }

        public double Price
        {
            get;set;
        }

        public string Builder
        {
            get;set;
        }

        public string Model
        {
            get;set;
        }

        public string Type
        {
            get;set;
        }
        public string BackWood
        {
            set;get;
        }

        public string TopWood
        {
            get;set;
        }

        public override string ToString()
        {
            return "SerialNumber : " + SerialNumber +
                "Price :" + Price +
                "Bulider :" + Builder +
                "Model :" + Model +
                "Type:" + Type +
                "Backwood" + BackWood +
                "TopWood:" + TopWood;
        }

       
    }
}
