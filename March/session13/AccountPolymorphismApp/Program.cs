using AccountPolymorphismApp.Model;
using System;


namespace AccountPolymorphismApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CaseStudy1();
            //CaseStudy2();
            CaseStudy3();

        }

        private static void CaseStudy3()
        {
            SavingAccount acc1 = new SavingAccount(1001, 5000, "Ekta");
            acc1.Deposite(2000);
            PrintDetails(acc1, "Details of account");
            CurrentAccount acc2 = new CurrentAccount(1005, 6000, "Ankkit");
            acc2.Deposite(3000);
            PrintDetails(acc2, "Details of account");
        }

        private static void CaseStudy2()
        {
            SavingAccount acc1 = new SavingAccount( 1001,5000, "Ekta");
            acc1.Withdraw(2000);
            PrintDetails(acc1, "Details of account");
            CurrentAccount acc2 = new CurrentAccount( 1005,6000, "Ankkit");
            acc2.Withdraw(3000);
            PrintDetails(acc2, "Details of account");
        }

        private static void CaseStudy1()
        {
            SavingAccount acc1 = new SavingAccount(1000,1001, "Ekta");
            PrintDetails(acc1, "Details of account");
            CurrentAccount acc2 = new CurrentAccount(2000, 1005, "Ankkit");
            PrintDetails(acc2, "Details of account");

        }

        static void PrintDetails(Account account,string title)
        {
            Console.WriteLine(title.ToUpper());
            
            Console.WriteLine("Account Balance"+account.Balance);
            Console.WriteLine("Account no:"+account.Accountno);
            Console.WriteLine("Account Name:"+account.Name);

        }
    }
}
