using System;
using EmployeePolymorphismApp.Model;

namespace EmployeePolymorphismApp.Model
{
     public class QualityAnalyst : Employee
    {
        private double perks;
        public QualityAnalyst(int id, string name, double basic) : base(id, name, basic)
        {
        }
        public override double CalculateAnnualSalary()
        {
            perks = 0.4 * _basic;
            return ((perks + _basic)*12);
        }
    }
}
