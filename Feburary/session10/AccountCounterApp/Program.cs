using AccountApp.Model;
using System;


namespace AccountCounterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CaseStudy1();
            //making static method which is going to be the part of class
            CaseStudy2();
            CaseStudy3();

        }

        private static void CaseStudy3()
        {
            Console.WriteLine(".........Case study 3  .......");
            Account acc1 = new Account(1001, 500, "A");
            Console.WriteLine(acc1.InstanceCount);


            Account acc2 = new Account(1001, 500, "A");
            Console.WriteLine(acc2.InstanceCount);

            Account acc3 = new Account(1001, 500, "A");
            Console.WriteLine(acc3.InstanceCount);
        }

        private static void CaseStudy2()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(".........Case study2.......");
            Account Account = new Account(1001, 500, "A");
            Console.WriteLine(Account.GetHead());


            Account acc2 = new Account(1001, 500, "A");
            Console.WriteLine(Account.GetHead());

            Account acc3 = new Account(1001, 500, "A");
            Console.WriteLine(Account.GetHead());

            Console.ResetColor();
        }

        private static void CaseStudy1()
        {
            Console.WriteLine("............Case study1.....");
            Account acc1 = new Account(1001, 500, "A");
            Console.WriteLine(acc1.InstanceCount);


            Account acc2 = new Account(1001, 500, "A");
            Console.WriteLine(acc1.InstanceCount);

            Account acc3 = new Account(1001, 500, "A");
            Console.WriteLine(acc1.InstanceCount);
        }
    }
}
