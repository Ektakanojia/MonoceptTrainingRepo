using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism.Model
{
    internal class Developer : Employee
    {

        private double _performanceAllowance;
        public Developer(int id, string name, double basicSalary) : base(id, name, basicSalary)
        {
           _performanceAllowance = basicSalary * .50;

        }

        public double _performaceAllowance
        {
            get { return _performanceAllowance; }
        }

        public override double CostToCompany
        {
            get
            {
                return (BasicSalary+_performanceAllowance)*12;
            }
        }

        public override string SalaryBreakUp
        {
            get
            {
                string salaryFormate = "";
                salaryFormate += "performance allowance : " + _performanceAllowance;
                return salaryFormate;
            }
        }

        public override string Role
        {
            get
            {
                return "Developer";
            }
        }
    }
}
