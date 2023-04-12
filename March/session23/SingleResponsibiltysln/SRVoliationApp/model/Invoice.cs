using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRVoliationApp.model
{
    internal class Invoice
    {
        private int _id;
        private string _description;
        private int _cost;
        private double _discountPercent;
        private const double _tax = .10;

        public Invoice(int id, string description, int cost, double discountPercent)
        {
            _id = id;
            _description = description;
            _cost = cost;
            _discountPercent = discountPercent;


        }
        public double CalculateTax()
        {
            return _cost* _tax;
        }
        public double CalculateDiscount() 
        {
            return _cost * _discountPercent;
        }
        public double FinalCost()
        {
            return _cost+CalculateTax()-CalculateDiscount();
        }

        public void PrintDetails()
        {
            string template =$"id: {_id}"+
                             $"description:{_description}"+
                             $"cost:{_cost}"+
                             $"tax amt is :{CalculateTax()} " +
                             $"{CalculateDiscount()}";
            Console.WriteLine(template);

        }
    }
}
