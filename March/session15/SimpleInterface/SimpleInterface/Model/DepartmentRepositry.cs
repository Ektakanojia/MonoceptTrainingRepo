using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterface.Model
{
    internal class DepartmentRepositry : ICurdable
    {
        public void Create()
        {
            Console.WriteLine("Department Create operation");
        }

        public void Delete()
        {
            Console.WriteLine("Department Delete operation");
        }

        public void Read()
        {
            Console.WriteLine(" Department Read operation");
        }

        public void Update()
        {
            Console.WriteLine("Department Update operation");   
        }
    }
}
