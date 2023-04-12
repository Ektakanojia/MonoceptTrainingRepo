using AccountApp.Model;
using HDFCBankSubscriber.Notifier;

namespace HDFCBankSubscriber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(101,2000,"Ekta");
            acc1.AddSubscriber(new WhatsAppNotifier());
            acc1.Deposit(100);
        }
    }
}