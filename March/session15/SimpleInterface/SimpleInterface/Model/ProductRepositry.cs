using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterface.Model
{
    internal class ProductRepositry : ICurdable
    {
        public void Create()
        {
            Console.WriteLine("Product Repositry created");
        }

        public void Delete()
        {
            Console.WriteLine("Product Repositry created");
        }

        public void Read()
        {
            Console.WriteLine("Product Repositry created");
        }

        public void Update()
        {
            Console.WriteLine("Product Repositry created");
        }
    }
}
