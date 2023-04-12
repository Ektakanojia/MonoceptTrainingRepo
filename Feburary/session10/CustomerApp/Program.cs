using System;
using CustomerApp.Model;
namespace CustomerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
        }

        private static void CaseStudy1()
        {
            //throw new NotImplementedException();
            Customer customer1 = new Customer("Ekta kanojia", 10);
            Customer customer2 = new Customer("Ankit", 10);
            Customer customer3 = new Customer("Adii", 10);
            Console.WriteLine(customer1.Id);
            Console.WriteLine(customer2.Id);
            Console.WriteLine(customer3.Id);
            Console.WriteLine();
        }

    }
}
