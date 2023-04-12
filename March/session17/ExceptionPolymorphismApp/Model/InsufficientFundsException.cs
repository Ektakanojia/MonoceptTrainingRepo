using AccountApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPolymorphismApp.Model
{
    internal class InsufficientFundsException:Exception
    {
        private int _accountno;
        private string _name;
        private double _balance;
        private double _withdrawAmount;
        
        public InsufficientFundsException(int accountno,string name, double balance, double withdrawAmount)
        {
             _accountno= accountno;
            _name = name;
            _balance = balance; 
            _withdrawAmount = withdrawAmount;
        }

       

        public override string Message
        {
            get
             {
                 string template = "";
                 template += "accountno :" + _accountno;
                 template += "Name :" + _name;
                 template += "balance :" + _balance;
                 template += "withdrawamount:" + _withdrawAmount;
                 template += "please maintanced the suffienct amount";
                 return template;
             }
          
        }

      
    }
}
