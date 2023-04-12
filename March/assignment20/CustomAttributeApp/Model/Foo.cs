using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributeApp.Model
{
    internal class Foo
    {
        private string _name;
        private int _rollNo;
        private string _email;
        private int _age;


        public Foo(string name, int rollNo, string email, int age)
        {
            _name = name;
            _rollNo = rollNo;
            _email = email;
            _age = age;
        }

        public string getName()
        {
            return _name;
        }

        [NeedToRefactor("Need to refactor","return rollno")]
        public int getRollNo()
        {
            return _rollNo;
        }
        [NeedToRefactor("Need to refactor","return email")]
        public string getEmail()
        {
            return _email;
        }

        public int getAge()
        {
            return _age;
        }
    }
}
