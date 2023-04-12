using StudentApp.Model;
using System;


namespace StudentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //student studentdetails = new student("ekta kanojia", 30, 7);
            //console.writeline("name is" + studentdetails.name);
            //console.writeline(studentdetails.percentage);
            //console.writeline(studentdetails.rollno);
            CaseStudy1();
        }
        private static void CaseStudy1()
        {
            Student studentdetails = new Student("Ekta kanojia", 30,7);
            studentdetails.CalculatePercentage(6);
            studentdetails.CheckName("Ektakanojia");
            studentdetails.ValidateRollno(-10);
            PrintDetails(studentdetails);
        }
        public static void PrintDetails(Student student)
        {
            Console.WriteLine("Name is :"+ student.Name);
            Console.WriteLine("Percentage is:" +student.Percentage);
            Console.WriteLine("Roll no:"+student.Rollno);

        }

    }
}
