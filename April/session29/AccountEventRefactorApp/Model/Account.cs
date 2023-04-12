﻿
using System;


namespace AccountEventRefactorApp.Models
{
    // delegate void DBalanceChange(Account account);
    internal class Account
    {
        private readonly int _accountno;
        private double _balance;
        private readonly string _name;
        private const double MIN_Balanace = 500;
        public event Action<Account>OnBalanceChange =null;
        public Account(int accountno, double balance, string name)
        {
            _accountno = accountno;
            _balance = balance;
            _name = name;
        }
        public Account(int accountno, string name)
        {
            _accountno = accountno;
            _name = name;
            _balance = MIN_Balanace;
        }
        private bool SufficientFund(double withdrawamount)
        {
             double amountAfterWithDraw = _balance - withdrawamount;
             return amountAfterWithDraw >= _balance;
        }
        public void Deposite(double amount)
        {
            _balance += amount;
            if(OnBalanceChange!= null)
            {
                OnBalanceChange(this);
            }
           
        }
        public void Withdraw(double amount)
        {
            //double amountAfterWithDraw = _balance - amount;
            if (SufficientFund(amount) )
            {
                _balance-= amount;
                if (OnBalanceChange != null)
                {
                    OnBalanceChange(this);
                }
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
    }
}
