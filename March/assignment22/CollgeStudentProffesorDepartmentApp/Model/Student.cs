using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollgeStudentProffesorDepartmentApp.Model
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Department Department { get; set; }

        public Student(int id, string name, int age,Department department)
        {
            Id = id;
            Name = name;
            Age = age;
            Department = department;

        }


    }
}
