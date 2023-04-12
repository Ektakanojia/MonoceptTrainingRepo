using System;


namespace AccountTransactionApp.Model
{
    internal class Account
    {
        private readonly int _accountno;
        private double _balance=0;
        private readonly string _name;
        private const double MIN_Balanace = 500;
        private readonly List<Transaction> _transactions;
        public Account(int accountno, double balance, string name)
        {
            _accountno = accountno;
           // _balance = balance;
            _name = name;
            _transactions = new List<Transaction>();
            //every opening account has intial Balance 2nd method
            //_transactions.Add(new Transaction { Type = 'D', Amount = amount, Time = DateTime.Now });

            Deposite(balance);
        }
        public Account(int accountno, string name):this(accountno,MIN_Balanace,name)
        {
          
        }
        private bool SufficientFund(double withdrawamount)
        {
             double amountAfterWithDraw = _balance - withdrawamount;
             return amountAfterWithDraw < _balance;
        }
        public void Deposite(double amount)
        {
            _balance += amount;
            _transactions.Add(new Transaction {Type ='D',Amount= amount,Time=DateTime.Now});
        }
        public void Withdraw(double amount)
        {
            //double amountAfterWithDraw = _balance - amount;
            if (SufficientFund(amount) )
            {
                _balance-= amount;
                _transactions.Add(new Transaction { Type = 'W', Amount = amount, Time = DateTime.Now });
            }
            else
            {
                Console.WriteLine("NO fund");
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
        public IEnumerable<Transaction> Transactions 
        { 
            get 
            { 
                return _transactions; 
            } 
        }
    }
}
