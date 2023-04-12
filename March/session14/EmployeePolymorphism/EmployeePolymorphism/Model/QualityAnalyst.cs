using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism.Model
{
    internal class QualityAnalyst : Employee
    {
        private double _perk;
        public QualityAnalyst(int id, string name, double basicSalary) : base(id, name, basicSalary)
        {
            _perk= basicSalary*.40;
        }

        public double Perk
        {
            get { return _perk; }
        }
        public override double CostToCompany
        {
            get
            {
                return (BasicSalary + _perk)*12;
            }
        }

        public override string SalaryBreakUp
        {
            get
            {
                string salaryFormate = "";
                salaryFormate += "perk : " + _perk;
                return salaryFormate;
            }
        }
        public override string Role
        {
            get
            {
                return "Quality Analyst";
            }
        }
    }
}
