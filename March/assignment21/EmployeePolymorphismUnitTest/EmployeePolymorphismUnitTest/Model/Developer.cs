using System;
using EmployeePolymorphismApp.Model;

namespace EmployeePolymorphismApp.Model
{
    public class Developer : Employee
    {
        private double _pa;
        private double _ota;
        public Developer(int id, string name, double basic) : base(id, name, basic)
        {
        }
        public override double CalculateAnnualSalary()
        {
            _pa = 0.5 * _basic;
            _ota = 0.4 * _basic;
            return ((_pa + _ota + _basic)*12);
        }

    }
}
