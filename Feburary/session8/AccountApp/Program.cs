using AccountApp.Model;
using System;


namespace AccountApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Account accountA = new Account(3036,"Ekta kanojia");
            //Console.WriteLine("name :"+accountA.Name);
            //Console.WriteLine("balance :" + accountA.Balance);
            //Console.WriteLine("accountno:"+accountA.Accountno);

            //Account accountB = new Account(3037,1000,"subran");
            //Console.WriteLine("name :" + accountB.Name);
            //Console.WriteLine("balance :" + accountB.Balance);
            //Console.WriteLine("accountno:" + accountB.Accountno);
            
            //accountA.Deposite(1000);
            //Console.WriteLine(accountA.Balance);
            //CaseStudy1();
            //CaseStudy2();
            //CaseStudy3();
            CaseStudy4();
        }

        private static void CaseStudy4()
        {

            Account accountB = new Account(3037, "subran");
            accountB.Withdraw(1000);
            //PrintDetails(accountB);
        }

        private static void CaseStudy3()
        {
            Account accountB = new Account(3037, 1000, "subran");
            accountB.Deposite(1000);
            PrintDetails(accountB);
        }

        private static void CaseStudy2()
        {
            Account accountB = new Account(3037, 1000, "subran");
            PrintDetails(accountB);
        }

        private static void CaseStudy1()
        {
            Account accountA = new Account(3036, "Ekta kanojia");
            PrintDetails(accountA);
        }

        static void PrintDetails(Account account)
        {
            Console.WriteLine("name :" + account.Name);
            Console.WriteLine("balance :" + account.Balance);
            Console.WriteLine("accountno:" + account.Accountno);
        }
    }
}
