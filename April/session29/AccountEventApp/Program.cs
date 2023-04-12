﻿using AccountEventApp.Models;

namespace AccountEventApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, 1000, "Ekta kanojia");
            //acc1.Deposite(1000);
            acc1.OnBalanceChange += SendSms;
            acc1.OnBalanceChange += SendEmail;
            acc1.Deposite(200);
            
        }

        private static void SendEmail(Account acc)
        {
            Console.WriteLine("Sending Email to:" + acc.Name);
            Console.WriteLine("Balance changed :" + acc.Balance);
            Console.WriteLine();
        }

        static void SendSms(Account acc)
        {
            Console.WriteLine("Sending Sms to:"+acc.Name);
            Console.WriteLine("Balance changed :" + acc.Balance);
            Console.WriteLine();
        }
        
    }
}