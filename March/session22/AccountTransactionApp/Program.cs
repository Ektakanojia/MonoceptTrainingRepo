using AccountTransactionApp.Model;

namespace AccountTransactionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Ekta");
            Console.WriteLine(acc1.Balance);
            acc1.Deposite(1000);
            acc1.Withdraw(100);
            //display final balance
            Console.WriteLine(acc1.Balance);
            //Console.WriteLine(acc1.Transactions.Count);
            //it will display the type and we override the tostring method 
           // CaseStudy1(acc1);
            CaseStudy2(acc1);


        }

        private static void CaseStudy2(Account acc1)
        {
           IEnumerator<Transaction> enumerator= acc1.Transactions.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }

        private static void CaseStudy1(Account acc1)
        {
            foreach (Transaction t in acc1.Transactions)
            {
                Console.WriteLine(t);
            }
        }
    }
}