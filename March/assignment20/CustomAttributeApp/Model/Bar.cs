using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributeApp.Model
{
    internal class Bar
    {
        private string _name;
        private int _rollNo;
        private string _email;
        private int _age;

        public Bar(string name, int rollNo, string email, int age)
        {
            _name = name;
            _rollNo = rollNo;
            _email = email;
            _age = age;
        }

        [NeedToRefactor("Need to refactor","Return name")]
        public string getName()
        {
            return _name;   
        }

        public int getRollNo()
        {
            return _rollNo;
        }

        public string getEmail()
        {
            return _email;
        }

        [NeedToRefactor("Need to refactor","Return age")]
        public int getAge()
        {
               return _age;
        }
    }
}
