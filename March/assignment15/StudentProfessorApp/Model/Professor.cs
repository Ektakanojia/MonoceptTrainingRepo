using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentProfessorApp.Model
{
    internal class Professor : Person
    {

        private double _basicSalary;
        private double _houseRentAllowance;
        private double _travallingAllowance;
        private double _performaceAllowance;
        private Branch _branch;
        public Professor(int id, string address, string dob, Branch branch) : base(id, address, dob)
        {
            _branch = branch;
        }

        public static double CalculateSalary(double basicSalary, double houseRentAllowance, double travellingAllowance, double performanceAllowance)
        {
            houseRentAllowance = basicSalary * .60;
            travellingAllowance = basicSalary * .50;
            performanceAllowance = basicSalary * .50;
            return ((basicSalary + houseRentAllowance + travellingAllowance + performanceAllowance) * 12);
        }

        public override string Profession
        {
            get
            {
                return "Professor";
            }
        }

        public Branch Branch
        {

            get
            {
                return _branch;
            }
        }
        public double BasicSalary
        {
            get { return _basicSalary; }
        }
        public double HouseRentAllowance
        {
            get
            {
                return _houseRentAllowance;
            }
        }

        public double TravelingAllowance
        {
            get
            {
                return _travallingAllowance;
            }
        }
        public double PerformaceAllowance
        {
            get
            {
                return _performaceAllowance;
            }
        }




    }
}
