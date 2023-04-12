using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism.Model
{
    internal class Manager : Employee
    {
        private double _houseRentAllowance;
        private double _travellingAllowance;

        public Manager(int id, string name, double basicSalary) : base(id, name, basicSalary)
        {
            _houseRentAllowance =basicSalary * .60;
            _travellingAllowance = basicSalary * .50;
        }

        public double HouseRentAllowance
        {
            get { return _houseRentAllowance;}
        }

        public double TravellingAllowance
        {
            get { return _travellingAllowance;}
        }

        public override double CostToCompany
        {
            get
            {
                return (BasicSalary+_houseRentAllowance+_travellingAllowance)*12;
            }
        }
        public override string SalaryBreakUp
        {
            get
            {
                string salaryFormate = "";
                salaryFormate += "houseRentAllowance : " + _houseRentAllowance;
                salaryFormate += "travellingAllowance : " + _travellingAllowance;
                return salaryFormate;
            }
        }
        public override string Role
        {
            get
            {
                return "Manager";
            }
        }
    }
}
