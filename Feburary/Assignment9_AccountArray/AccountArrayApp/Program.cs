using AccountArrayApp.Model;
using System;
using System.Security.Principal;


namespace AccountArrayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

           // CaseStudy1();
           // CaseStudy2();
            //CaseStudy3();
             CaseStudy4();
            //CaseStudy5();
            CaseStudy6();
        }

        private static void CaseStudy6()
        {
            Account[] manyArray = new Account[100];
            foreach (Account account in manyArray) 
            { 
             
            }
        }

        /* private static void CaseStudy5()
          {
              Account[] manyAccount = new Account[5];
              manyAccount[0] = new Account(3036, "Ekta kanojia", 20000);
              manyAccount[1] = new Account(3022, "Ankit ojha", 30000);
              manyAccount[2] = new Account(3067, "Subran", 80000);
              manyAccount[3] = new Account(3087, "vivek", 25000);
              manyAccount[4] = new Account(3034, "Ratnesh", 90000);
              Account largestName = new Account(0, "", 0);
              foreach(Account account in manyAccount)
             {
                 largestName= account.Large(manyAccount);
             }
              PrintDetails(largestName);

          }*/

        private static void CaseStudy4()
        {

            Console.WriteLine("......................Case study 4...............Print the Details of all richest account holder..........");
            Account[] manyAccount = new Account[5];

            manyAccount[0] = new Account(3036, "Ekta kanojia", 20000);
            manyAccount[1] = new Account(3022, "Ankit ojha", 30000);
            manyAccount[2] = new Account(3067, "Subran", 80000);
            manyAccount[3] = new Account(3087, "vivek", 25000);
            manyAccount[4] = new Account(3034, "Ratnesh", 90000);
            Account richest = new Account(0,"",0) ;
            foreach (Account account in manyAccount)
            {
                richest = account.FindWhoIsTheRichestPerson(manyAccount);
                
            }
            PrintDetails(richest,"");
           
        }
        /*private static void CaseStudy3()
        {

           
            Console.WriteLine("..........Case Study 3 ...........Find the richest account holder among two ");
            Account ankit = new Account(3022, "ankit ojha", 30000);
            Account ekta = new Account(3036, "Ekta kanojia", 20000);
            Account richest=ankit.FindTheRichestAccountHolder(ekta);
            Console.WriteLine(richest.Name); 
            Console.WriteLine(richest.Balance);
           
        }*/

        private static void CaseStudy2()
        {
           
            Console.WriteLine("...........Case study2................created a array of account type that hold many account");
            Account[] manyAccount = new Account[5];
            manyAccount[0] = new Account(3036, "Ekta kanojia", 20000);
            manyAccount[1] = new Account(3022, "Ankit ojha", 30000);
            manyAccount[2] = new Account(3067, "Subran", 80000);
            manyAccount[3] = new Account(3087, "vivek", 25000);
            manyAccount[4] = new Account(3034, "Ratnesh", 90000);
            foreach(Account account in manyAccount)
            {
                PrintDetails(account);
            }

        }

        private static void CaseStudy1()
        {
            Console.WriteLine("..........CaseStudy 1...............");
            Account account = new Account(3036, "Ekta kanojia", 20000);
            PrintDetails(account, "");
        }

        public static void PrintDetails(Account account, string title = "")
        {
            Console.WriteLine("Account No of the Richest Account holder :" + account.Accountno);
            Console.WriteLine("Name of the Richest account holder is:" + account.Name);
            Console.WriteLine("Balance of the richest account holder is:" + account.Balance);
        }
    }
}
