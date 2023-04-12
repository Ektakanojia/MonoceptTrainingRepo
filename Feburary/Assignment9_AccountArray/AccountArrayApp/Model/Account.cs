using System;


namespace AccountArrayApp.Model
{
    internal class Account
    {
        private int _accountno;
        private string _name;
        private int _balance;
        private int _range;
        public Account(int accountno, string name, int balance)
        {
            _accountno = accountno;
            _name = name;
            _balance = balance;
        }
        public Account(int range)
        {
            _range = range;
        }

       
        public  Account FindWhoIsTheRichestPerson(Account[] manyAccount)
        {
            Account maxAccountHolder = manyAccount[0];
            for(int i = 1; i < manyAccount.Length; i++)
            {

                Account accountHolder= manyAccount[i];
                if ( accountHolder.Balance>maxAccountHolder.Balance)
                {
                     maxAccountHolder=accountHolder;
                }
                
                
            }
            return maxAccountHolder;
           

        }
        public static int LargestName(string name)
        {

        }



        public int Accountno
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
        public int Balance
        {
            get
            {
                return _balance;
            }
        }
    }
}
