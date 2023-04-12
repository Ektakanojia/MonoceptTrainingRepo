using SimpleInterface.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerRepositry customerRepositry = new CustomerRepositry();
            //customerRepositry.Create();
            DepartmentRepositry departmentRepositry = new DepartmentRepositry();
           // departmentRepositry.Update();
           ProductRepositry productRepositry = new ProductRepositry();
            DoDbOperation(customerRepositry);
          
            DoDbOperation(departmentRepositry);
            
            DoDbOperation(productRepositry);
        }

        public static void DoDbOperation(ICurdable curdable) //ISA curable
        {
            Console.WriteLine("Doing db operation");
            curdable.Read();
            curdable.Create();
            curdable.Delete();
            curdable.Update();
            Console.WriteLine();
        }
    }
}
