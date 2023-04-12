using AccountApp.Model;
using PublisherCoreLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxisBankSubscriber.Notifier
{
    internal class EmailNotifier : IAccountNotifier
    {
        public void Notifiy(Account account)
        {
            Console.WriteLine("Seding email notification");
            Console.WriteLine("Account holder is " + account.Name);
            Console.WriteLine("Final Balance is " + account.Balance);
            Console.WriteLine();
        }
    }
}
