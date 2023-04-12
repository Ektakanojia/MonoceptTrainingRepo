using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterface.Model
{
    internal class CustomerRepositry : ICurdable

    {
        public void Create()
        {
            Console.WriteLine("Customer Repositry created");
        }

        public void Delete()
        {
            Console.WriteLine("Customer Repositry  Delete");
        }

        public void Read()
        {
            Console.WriteLine("Customer Repositry Read");
        }

        public void Update()
        {
            Console.WriteLine("Customer Repositry update");
        }
    }
}
