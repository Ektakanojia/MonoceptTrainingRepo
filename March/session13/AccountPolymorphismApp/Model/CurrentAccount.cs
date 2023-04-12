using AccountPolymorphismApp.Model;
using System;


namespace AccountPolymorphismApp.Model
{
    internal class CurrentAccount : Account
    {
        private const int OVER_DRAFT = -5000;

        public CurrentAccount(int accountno, double balance, string name) : base(accountno, balance, name)
        {

        }

      
        public override void Withdraw(double amount)
        {

            if (_balance - amount >= OVER_DRAFT)
            {
                _balance-= amount;
                return;
            }
            else
            {
                throw new Exception("No funds");
            }
            
        }

       
    }
}
