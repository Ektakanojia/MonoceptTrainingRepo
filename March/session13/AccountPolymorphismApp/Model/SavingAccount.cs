using System;
using AccountPolymorphismApp.Model;


namespace AccountPolymorphismApp.Model
{
    internal class SavingAccount : Account
    {
        private const int MIN_Balance = 1000;
        public SavingAccount(int accno,double balance,string name) :base(accno, balance,name)
        { 

        }
       
        public override void Withdraw(double amount)
        {
            if(_balance-amount>=MIN_Balance)
            {
                _balance = _balance-amount;
                return;
            }
            else
            {
                throw new Exception("No funds");
            }
          
        }
    }
}
