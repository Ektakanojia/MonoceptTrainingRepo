
using System;


namespace AccountPolymorphismApp.Model

{
    public abstract class Account
    {
        private  int _accountno;
        protected double _balance;
        private readonly string _name;
        
        public Account(int accountno, double balance, string name)
        {
            _accountno = accountno;
            _balance = balance;
            _name = name;
        }
         
       
        public void Deposite(double amount)
        {
            _balance += amount;
        }
        public abstract void Withdraw(double amount);
        
          
           
    
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
