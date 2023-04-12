using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnboxingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
        }
        private static void CaseStudy2()
        {
            Console.WriteLine(".......Boxing......convertin value type to reference type...");
            int num = 100;
            Console.WriteLine(num);
            Console.WriteLine(num.GetType());
            Object obj=new Object();
             obj = num;
             num = 200;
            Console.WriteLine(obj);
            Console.WriteLine(obj.GetType());
        }

        private static void CaseStudy1()
        {
            Console.WriteLine("........case study1.....unboxing.....converting it from reference type to value type");
            Object num=new Object();
            Console.WriteLine(num);
            Console.WriteLine(num.GetType());
            num = 100;
            num = (int)num + 10;
            Console.WriteLine(num);
            Console.WriteLine(num.GetType());


        }
    }
}
