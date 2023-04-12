using CollgeStudentProffesorDepartmentApp.Model;
using System.Runtime.Intrinsics.Arm;

namespace CollgeStudentProffesorDepartmentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           College college  = new College("NITRR");

            Department mca = new Department("Master of computer Application", "MCA");
            Department betch = new Department("Bachelor's of technology", "BETCH");
            Department civil = new Department("Civil Engineering", "CIVIL");

            college.AddDepartment(mca);
            college.AddDepartment(betch);
            college.AddDepartment(civil);

            college.AddStudent(new Student(1001,"Ekta",23,betch));
            college.AddStudent(new Student(1002,"ANKIT",23,civil));
            college.AddStudent(new Student(1003,"Vidya",24,mca));

            college.AddProffesor(new Proffesor("Dr Dibakar Saha", 34, "Professor", mca));
            college.AddProffesor(new Proffesor("Dr Bikrol", 34, "Professor", civil ));
            college.AddProffesor(new Proffesor("Dr Bikrol", 34, "Professor", civil ));

            PrintDetails(college);
        }

        private static void PrintDetails(College college)
        {
            Console.WriteLine($"College Name :{college.Name}");

            Console.WriteLine("Aviable Departments in collge");

            foreach(Department dep in college.Departments)
            {
                Console.WriteLine($"Department Name :{dep.DepartmentName}");
                Console.WriteLine($"Depatment Code :{ dep.DepartmentCode}");

            }

            Console.WriteLine("List of student");
            foreach(Student student in college.Students)
            {
                Console.WriteLine($"Name:{student.Name}"); 
                Console.WriteLine($"ID:{student.Id}");
                Console.WriteLine($"Age:{student.Age}");
                Console.WriteLine($"Department:{student.Department.DepartmentName}");
            }

            Console.WriteLine("List of Professor");
            foreach (Proffesor proffesor in college.Proffesor)
            {
                Console.WriteLine($"Name:{proffesor.Name}");
                Console.WriteLine($"Age:{proffesor.Age}");
                Console.WriteLine($"Designation:{proffesor.Designation}");
                Console.WriteLine($"Department:{proffesor.Department.DepartmentName}");
               
            }

        }
    }
}