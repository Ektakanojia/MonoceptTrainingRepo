using StudentProfessorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProfessorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Student student = new Student(1001, "Lucknow", "21-01-2002",Branch.MCA);
            Professor professor = new Professor(1003, "MP", "20 -02-1988",Branch.BSC);
            
            PrintDetails(student);
            PrintDetails(professor);


        }
        static void PrintDetails(Person person)
        {

            Console.WriteLine("Profession:" + person.Profession);
            Console.WriteLine("Person ID:"+person.Id);
            Console.WriteLine("Person Address :"+person.Address);
            Console.WriteLine("Person DOB :"+person.dob);
            if(person.Profession== "Professor")
            {
                Professor professor= person as Professor;
                Console.WriteLine(professor.Branch);
            }
            else
            {
                Student student= person as Student;
                Console.WriteLine(student.Branch);
            }
           
            Console.WriteLine();
        }
       
    }
}
