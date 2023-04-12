using EmployeeToStringEqualApp.Model;
using System;


namespace EmployeeToStringEqualApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();

        }

        private static void CaseStudy2()
        {
            //throw new NotImplementedException();
            var employeeA = new Employee(21, "Ekta", 100);
            var employeeB = new Employee(21, "Ekta", 100);

            //reference equality.
            Console.WriteLine(employeeA == employeeB);
            var employeeC = employeeB;
            Console.WriteLine(employeeC == employeeB);
            //Value based equality
            Console.WriteLine("Values Based equality A & B {0}:",employeeA.Equals(employeeB) );
        }

        private static void CaseStudy1()
        {
            var employeeA = new Employee(21, "Ekta", 100);
            Console.WriteLine(employeeA);
            Console.WriteLine(employeeA.ToString());
            Console.WriteLine(employeeA.GetType());
        }
    }
}
