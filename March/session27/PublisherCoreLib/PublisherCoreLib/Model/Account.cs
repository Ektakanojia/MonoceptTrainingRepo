
using PublisherCoreLib.Model;
using System;


namespace AccountApp.Model
{
    public class Account
    {
        private readonly int _accountno;
        private double _balance;
        private readonly string _name;
        private const double MIN_Balanace = 500;
        private  List<IAccountNotifier> _notifications;
        public Account(int accountno, double balance, string name)
        {
            _accountno = accountno;
            _balance = balance;
            _name = name;
            _notifications = new List<IAccountNotifier>();
        }
        public Account(int accountno, string name):this(accountno,MIN_Balanace,name)
        {
           
        }
        public void AddSubscriber(IAccountNotifier notifier)
        {
            _notifications.Add(notifier);
        }
        public void Deposit(double amount)
        {
            _balance += amount;
            CallNotification();
        }
        private void CallNotification()
        {
            foreach (IAccountNotifier notifier in _notifications)
            {
                notifier.Notifiy(this); 
                //when ever the function accepting the same class object
                //and we are in the same classbso we use the this keyword
                //we are already in account class that is why we pass use the this
            }
        }
        private bool SufficientFund(double withdrawamount)
        {
             double amountAfterWithDraw = _balance - withdrawamount;
             return amountAfterWithDraw <= _balance;
        }
        
        public void Withdraw(double amount)
        {
            //double amountAfterWithDraw = _balance - amount;
            if (SufficientFund(amount) )
            {
                _balance-= amount;
                CallNotification();
            }
            else
            {
                throw new Exception("No funds");
            }
        }
        public double Balance
        {
            get { 
                return _balance;
            }
        }
        public double Accountno
        {
            get { 
                return _accountno; 
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
    }
}
