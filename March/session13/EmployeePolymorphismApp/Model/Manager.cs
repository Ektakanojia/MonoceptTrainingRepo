using System;
using EmployeePolymorphismApp.Model;


namespace EmployeePolymorphismApp.Model
{
    internal class Manager : Employee
    {
        private double hra;
        private double ta;
        private double da;
         
        public Manager(int id, string name, double basic) : base(id, name, basic)
        {

        }

        public override double  CalculateAnnualSalary()
        {
            
            hra = 0.6 * _basic;
            ta = 0.5 * _basic;
            da= 0.5 * _basic;
            return((hra+ta+da+_basic)*12);
        }
    }
}
