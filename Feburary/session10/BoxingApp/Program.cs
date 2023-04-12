using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingApp
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
            Console.Write("..........Case Study 2..........");
            Object[] BoxedItems = new Object[3];
            BoxedItems[0] = 10d;
            BoxedItems[1] = 2.55d;
            BoxedItems[2] = 30.55d;
            Console.WriteLine(BoxedItems[0].GetType());
            Console.WriteLine(BoxedItems[1].GetType());
            Console.WriteLine(BoxedItems[2].GetType());
            double sum = 0;
            foreach (Object item in BoxedItems)
            {
                //unboxing 
               double unboxItem= (double)item;
                sum += unboxItem;
            }



        }

        private static void CaseStudy1()
        {
            Console.WriteLine("............Case study1...");
            object box = null; //box object of object class, null will give null pointer exception
            box = new object();
            Console.WriteLine(box.GetHashCode());
            Console.WriteLine(box.GetType());
            box = 100.55;
            Console.WriteLine(box.GetHashCode());
            Console.WriteLine(box.GetType());
            box = (double)box + 10;
            Console.WriteLine(box);
        }
    }
}
