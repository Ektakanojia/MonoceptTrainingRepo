using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollgeStudentProffesorDepartmentApp.Model
{
    internal class Proffesor
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string Designation
        {
            get; set;
        }
        public Department Department { get; set; }
        public Proffesor(string name, int age, string desigantion, Department department)
        {
            Name = name;
            Age = age;
            Designation = desigantion;
            Department = department;
        }

    }
}
