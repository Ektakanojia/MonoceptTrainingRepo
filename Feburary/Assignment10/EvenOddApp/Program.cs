using System;
using EvenOddApp.Model;

namespace EvenOddApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            //CaseStudy3();
            //CaseStudy4();
            CaseStudy5();
        }

        private static void CaseStudy5()
        {
            Console.WriteLine("....case study 5 return the array..........");
            FindEvenOdd obj= new FindEvenOdd();
            int[] _array = new int[100];

            
           /* foreach( obj  in _array)
            {
               obj.FindWhoIsEven(_array);
              
            }*/
            
        }

    
        private static void CaseStudy4()
        {
            Console.WriteLine("...............Casestudy4...........");
            FindEvenOdd even = new FindEvenOdd();
            even.GetEven(200, 300);

        }
      


        private static void CaseStudy3()
        {
            Console.WriteLine("...............Casestudy3...........");
            FindEvenOdd odd= new FindEvenOdd();
            odd.GetOdd(100, 200);

        }

        private static void CaseStudy2()
        {
            Console.WriteLine("...............Casestudy2...........");
            FindEvenOdd obj= new FindEvenOdd();
            obj.FindEven(100);
        }

        private static void CaseStudy1()
        {
            Console.WriteLine("...............Casestudy1...........");
            FindEvenOdd obj = new FindEvenOdd();
            obj.FindOdd(100);
        }
    }
}
