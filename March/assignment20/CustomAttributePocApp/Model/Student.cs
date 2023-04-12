using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributePocApp.Model
{
   
    internal class Student
    {
        private int _id;
        private string _name;
        private int _age;


        [CustomAttribute("name,decription","Assign student Details")]
        public void setDetails(int id, string name, int age)
        {
            _id = id;
            _name = name;
            _age = age;
        }
        [CustomAttribute("accessor","return the id")]
        public int getId()
        {
            return _id;
        }
        [CustomAttribute("accessor", "return the name")]
        public string getName()
        {
            return _name;
        }
        [CustomAttribute("accessor", "return the age")]
        public int getAge() 
        {
            return _age;
        }
    }
}
