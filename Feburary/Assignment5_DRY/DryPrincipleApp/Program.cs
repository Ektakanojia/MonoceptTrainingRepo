using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryPrincipleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            McaDepartment();
            EceDepartment();
            CseDepartment();
        }
        private static void McaDepartment()
        {
            Console.WriteLine("This is the Mca Deaprtment of :");
            College();
        }
        private static void EceDepartment()
        {
            Console.WriteLine("This is the Electronics Department of :");
            College();
        }
        private static void CseDepartment()
        {
            Console.WriteLine("This is the Computer science Department of :");
            College();
        }
        private static void College() {
            Console.WriteLine("National Institute of technology raipur");
        }
    }
}
