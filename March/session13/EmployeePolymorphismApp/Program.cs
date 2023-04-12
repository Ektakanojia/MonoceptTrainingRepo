using EmployeePolymorphismApp.Model;
using System;


namespace EmployeePolymorphismApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            CaseStudy3();
            CaseStudy4();
        }

        private static void CaseStudy4()
        {
            Console.WriteLine("........Case study 4..........");
            QualityAnalyst qa = new QualityAnalyst(1004, "Vidya", 22000);
            double annualSalary = qa.CalculateAnnualSalary();
            PrintDetails(qa, "Details of QA");
            Console.WriteLine("Annual salary of QA :" + annualSalary);
        }

        private static void CaseStudy3()
        {
            Console.WriteLine("........Case study 3..........");
            Developer devp = new Developer(1003, "Subran", 18000);
            double anuualSalary = devp.CalculateAnnualSalary();
            PrintDetails(devp, "");
            Console.WriteLine("Annual Salary of Developer :" + anuualSalary);
        }

        private static void CaseStudy2()
        {
            Console.WriteLine("........Case study 2..........");
            Manager mang = new Manager(1002, "Ankit", 30000);
            double annualSalary = mang.CalculateAnnualSalary();
            PrintDetails(mang, "");
            Console.WriteLine("Annual Salary of Manager :" + annualSalary);

        }

        private static void CaseStudy1()
        {
            Console.WriteLine("........Case study 1..........");
            Employee emp = new Employee(1001, "Ekta kanojia", 20000);
            double annulaSalary = emp.CalculateAnnualSalary();
            PrintDetails(emp, "");
            Console.WriteLine("Annul Salary of Employee :" + annulaSalary);

        }

        private static void PrintDetails(Employee emp, string v)
        {
            Console.WriteLine(v.ToUpper());
            Console.WriteLine("ID :" + emp.ID);
            Console.WriteLine("Name :" + emp.Name);
            Console.WriteLine("basic Salary :" + emp.Basic);
        }
    }
}
