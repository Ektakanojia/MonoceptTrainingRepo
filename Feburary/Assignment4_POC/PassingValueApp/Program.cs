using System;
using System.Diagnostics.CodeAnalysis;

namespace PassingValuesApp
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
        public static void CaseStudy1()
        {
            int mark = 100;
            UpdateMarkToZero(mark);
            Console.WriteLine(mark);
        }
        private static void CaseStudy2()
        {
            int salary = 1000;
            UpdateSalaryToZero(ref salary);
            Console.WriteLine("casestudy 2 salary value is {0} :", salary);
        }
        private static void CaseStudy3()
        {
            int[] scores = { 10, 20, 30, 40, 50 };
            UpdateScoresToZero(scores);
            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }
            Console.WriteLine("HashCode of score is {0}", scores.GetHashCode());
        }
        private static void CaseStudy4()
        {
            int sum, avg, product;
            Calculate(10,20,30,out sum,out avg,out product);
            Console.WriteLine("The sum is :{0},The avg is {1},The product is {2}",sum,avg,product);
            Console.WriteLine("Enter the number only");
            string input = Console.ReadLine();
            int no = 0;
            if(int.TryParse(input,out no))
            {
                Console.WriteLine(no*no);
            }
            else
            {
                Console.WriteLine("Number only allowed: " + input);
            }
        }
        private static void CaseStudy5()
        {

            DisplayMultiplication(first:10);
        }
        private static void DisplayMultiplication(int first)
        {

        }

        private static void Calculate(int first ,int second ,int third, out int avg,out int sum,out int product)
        {
             sum=first+second+third;
            avg = sum / 3;
            product=first*second*third;
        }
        private static void UpdateScoresToZero(int[] pscores)
        {
            for (int i = 0; i < pscores.Length; i++)
            {
                pscores[i] = 0;
            }
            Console.WriteLine("HashCode of score is {0}", pscores.GetHashCode());
        }
        private static void UpdateSalaryToZero(ref int psalary)
        {
            psalary = 0;
        }
        private static void UpdateMarkToZero(int mark)
        {
            mark = 0;
        }
    }
}
