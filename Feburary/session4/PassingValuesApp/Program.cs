using System;

namespace PassingValuesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
           // CaseStudy2();
            CaseStudy3();

        }
        public static  void CaseStudy1() {
            int mark = 100;
            UpdateMarkToZero(mark);
            Console.WriteLine(mark);
        }
        private static void CaseStudy2()
        {
            int salary = 1000;
            UpdateSalaryToZero(ref salary);
            Console.WriteLine("casestudy 2 salary value is {0} :",salary);
        }
        private static void CaseStudy3()
        {
            int[] scores = { 10, 20, 30, 40, 50 };
            UpdateScoresToZero(scores);
            foreach(int score in scores)
            {
                Console.WriteLine(score);
            }
            Console.WriteLine("HashCode of score is {0}",scores.GetHashCode());
        }
        private static void UpdateScoresToZero(int [] pscores)
        {
            for(int i=0;i<pscores.Length;i++)
            {
                pscores[i] = 0;
            }
            Console.WriteLine("HashCode of score is {0}", pscores.GetHashCode());
        }
        private static void UpdateSalaryToZero(  ref int psalary)
        {
            psalary= 0;
        }
        private static  void UpdateMarkToZero(int mark)
        {
            mark = 0;
        }
    }
}
