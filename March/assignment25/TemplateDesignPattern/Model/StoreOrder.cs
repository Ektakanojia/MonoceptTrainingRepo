using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPattern.Model
{
    internal class StoreOrder:OrderProcess
    {
        public override void doDelivery()
        {
            Console.WriteLine("Customer chosse item deliver at home");
        }

        public override void doPayment()
        {
            Console.WriteLine("Customer pay at counter through cash");
        }

        public override void doSelect()
        {
            Console.WriteLine("Customer chosse item  from shelf");
        }
    }
}
