using AccountApp.Model;
using PublisherCoreLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDFCBankSubscriber.Notifier
{
    internal class WhatsAppNotifier : IAccountNotifier
    {
        public void Notifiy(Account account)
        {
            Console.WriteLine("Seding what's app notification");
            Console.WriteLine("Account holder is " + account.Name);
            Console.WriteLine("Final Balance is " + account.Balance);
            Console.WriteLine();
        }
    }
}
