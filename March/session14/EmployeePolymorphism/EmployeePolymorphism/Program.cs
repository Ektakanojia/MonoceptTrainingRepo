using EmployeePolymorphism.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager(101, "Ekta", 20000);
            Developer developer = new Developer(102, "Ankit", 30000);
            QualityAnalyst qualityAnalyst = new QualityAnalyst(103, "Subran", 40000);
            PrintSalarySlipToConsole(manager);
            PrintSalarySlipToConsole(developer);
            PrintSalarySlipToConsole(qualityAnalyst);

            PrintSalarySlipToHtml(manager);
            PrintSalarySlipToHtml(developer);
            PrintSalarySlipToHtml(qualityAnalyst);
           
        }

        static void PrintSalarySlipToConsole(Employee employee)
        {
            Console.WriteLine("Employee Id :" + employee.ID);
            Console.WriteLine("Employee Name :" + employee.Name);
            Console.WriteLine("Employee Basic Salary:" + employee.BasicSalary);
            Console.WriteLine("Employee ctc :" + employee.CostToCompany);
            Console.WriteLine("Employee role:" + employee.Role);
            Console.WriteLine("Employee salary break up :" + employee.SalaryBreakUp);
            /* if(employee is Manager)
             {
                 Console.WriteLine("Employee Role is :Manager");
             }else if(employee is Developer)
             {
                 Console.WriteLine("Employee Role is :Developer");
             }*/
            Console.WriteLine();
        }

        static void PrintSalarySlipToHtml(Employee employee)
        {

            StreamWriter writer = new StreamWriter(employee.Name + ".html");
            writer.WriteLine("<body>");
            writer.WriteLine("<H1>");
            writer.WriteLine("Employee Id :" + employee.ID);
            writer.WriteLine("Employee Name :" + employee.Name);
            writer.WriteLine("Employee Basic Salary:" + employee.BasicSalary);
            writer.WriteLine("Employee ctc :" + employee.CostToCompany);
            writer.WriteLine("Employee role:" + employee.Role);
            writer.WriteLine("Employee salary break up :" + employee.SalaryBreakUp);
            writer.WriteLine("</H1>");
            writer.WriteLine("</body>");
            writer.Close();

        }
    }
}
