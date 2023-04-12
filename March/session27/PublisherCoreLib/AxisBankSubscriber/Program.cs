using AccountApp.Model;
using AxisBankSubscriber.Notifier;

namespace AxisBankSubscriber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(101, 1000, "Ekta");
            //acc1.Deposit(100);
            acc1.AddSubscriber(new EmailNotifier());    
            acc1.AddSubscriber(new SmsNotifer());
            acc1.Deposit(1000);
            acc1.Withdraw(100); 
        }
    }
}