using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeToStringEqualApp.Model
{
    internal class Employee
    {
        private int _id;
        private string _name;
        private double _salary;
        public Employee(int id, string name, double salary)
        {
            _id = id;
            _name = name;
            _salary = salary;
        }
       
        public override string ToString()
        {
            // return base.ToString();
            string template = "";
            template += "id :" + _id;
            template += "Name :" + _name;
            template += "Salary :" + _salary;
             template += "parent:"+base.ToString();
            return template;
        }
        public override bool Equals(object obj)
        {
            //return base.Equals(obj);
            Employee second =(Employee)obj;
            if(this.ID==second.ID && second.Name==this.Name)
                return true;
            return false;
        }

        public int ID
        {
            get { return _id; }
        }
        public string Name
        {
            get { return _name; }
        }
        public double Salary
        {
            get { return _salary; }
        }
    }

}
