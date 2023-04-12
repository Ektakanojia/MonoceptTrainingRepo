using EvenOddArrayApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddArrayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EvenOdd evenOdd= new EvenOdd();
            // CaseStudy1(evenOdd);
            //CaseStudy2(evenOdd);
            // CaseStudy3(evenOdd);
             CaseStudy4(evenOdd);

        }

        private static void CaseStudy4(EvenOdd evenOdd)
        {
            int[] oddNumber = evenOdd.GetOddElementInRange(100, 200);
            Console.WriteLine("Even number in the given range");
            PrintNumbers(oddNumber);
        }

        private static void CaseStudy3(EvenOdd evenOdd)
        {
            int[] evenNumbers = evenOdd.GetEvenElementInRange(100, 200);
            Console.WriteLine("Even number in the given range");
            PrintNumbers(evenNumbers);
        }

        private static void CaseStudy2(EvenOdd evenOdd)
        {
            int[] oddNumber = evenOdd.GetOddElement(100);
            Console.WriteLine("odd number between 1 to 100 ");
            PrintNumbers(oddNumber);


        }

        private static void CaseStudy1(EvenOdd evenOdd)
        {
            int[] evenNumbers = evenOdd.GetEvenElement(100);
            Console.WriteLine("Even Number from 1 to 100");
            PrintNumbers(evenNumbers);
        }

        private static void PrintNumbers(int[] numbers )
        {
           foreach(int number in numbers)
            {
             Console.WriteLine(number+ " ");
             
            }
            Console.WriteLine();
        }
    }
}
