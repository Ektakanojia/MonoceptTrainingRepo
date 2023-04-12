using AccountApp.Model;
using ExceptionPolymorphismApp.Model;

namespace ExceptionPolymorphismApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1001,500,"Ekta");
            try
            {
                account.Withdraw(100);
            }catch(InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("end of main");

        }
    }
}