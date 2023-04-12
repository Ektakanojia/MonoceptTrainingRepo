using System;

namespace EmployeePolymorphismApp.Model
{
    public  class Employee
    {
        private int _id;
        private string _name;
        protected double _basic; 

        public Employee(int id,string name,double basic) 
        { 
        _id= id;
        _name= name;
        _basic=basic;
        }
        public  virtual double  CalculateAnnualSalary()
        {
            return (_basic* 12);
           
        }
        public int ID
        {
            get { return _id; }
        }
        public string Name
        { 
            get { return _name; }
        }
        public double Basic 
        { 
            get { return _basic; }
           
        }
    }
}
