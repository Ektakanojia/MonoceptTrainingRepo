using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringImmuteableApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            CaseStudy3();
        }
        private static void CaseStudy1()
        {
            String userName = "Ekta kanojia";
            userName.ToUpper();
            Console.WriteLine(userName);
        }
        private static void CaseStudy2()
        {
            String userName ="Ekta kanojia";
            Console.WriteLine(userName.GetHashCode());
            userName += "Monocept";
            Console.WriteLine(userName.GetHashCode());
            userName += "@";
            Console.WriteLine(userName.GetHashCode());
            userName += "Gurgaon";
            Console.WriteLine(userName.GetHashCode());
            Console.WriteLine(userName);
        }
        private static void CaseStudy3()
        {
            StringBuilder userName = new StringBuilder();

            userName.Append("Ekta kanojia");
            Console.WriteLine(userName.GetHashCode());
            userName.Append("NIT-Raipur");
            Console.WriteLine(userName.GetHashCode());
            Console.WriteLine(userName);
        }


    }
}
