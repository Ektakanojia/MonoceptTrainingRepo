using System;


namespace AccountApp.Model
{
    internal class Account
    {
        private readonly int _accountno;
        private double _balance;
        private readonly string _name;
        private const double MIN_Balanace = 500;
        private static int _intsanceCount = 100;

        static Account()
        {
            _intsanceCount = 100;
            Console.WriteLine("inside static constructor");
        }
        public Account(int accountno, double balance, string name)
        {
            Console.WriteLine("inside normal constructor");
            _accountno = accountno;
            _balance = balance;
            _name = name;
            _intsanceCount += 1;
        }
        public Account(int accountno, string name) : this(accountno, MIN_Balanace, name)
        {
            /*_accountno = accountno;
            _name = name;
            _balance = MIN_Balanace;*/
        }
        private bool SufficientFund(double withdrawamount)
        {
            double amountAfterWithDraw = _balance - withdrawamount;
            return amountAfterWithDraw > _balance;
        }
        public void Deposite(double amount)
        {
            _balance += amount;
        }
        public void Withdraw(double amount)
        {
            //double amountAfterWithDraw = _balance - amount;
            if (SufficientFund(amount))
            {
                _balance -= amount;
            }
            else
            {
                Console.WriteLine("NO fund");
            }
        }
        public static int GetHead()
        {
            return _intsanceCount;
        }
        public double Balance
        {
            get
            {
                return _balance;
            }
        }
        public double Accountno
        {
            get
            {
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
        public int InstanceCount
        {
            get
            {

                return _intsanceCount;
            }
        }
        
    }
}
