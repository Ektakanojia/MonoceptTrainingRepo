using CustomerHashSetApp.Model;
using System;
using System.Collections.Generic;

namespace CustomerHashSetApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // CaseStudy1();
            //CaseStudy2();
            //create a customer
            CaseStudy3();
        }

        private static void CaseStudy3()
        {
            Customer c1 = new Customer(1, "Ekta");
            Customer c2 = new Customer(2, "Ankit abc");
            Customer c3 = new Customer(2, "Ankit");

            Console.WriteLine(c1.GetHashCode());
            Console.WriteLine(c2.GetHashCode());
            Console.WriteLine(c3.GetHashCode());
            HashSet<Customer> c = new HashSet<Customer>();
            Console.WriteLine(c.Count);
            foreach(Customer customer in c)
            {
                Console.WriteLine(customer.Name +"id"+customer.Id);
              
            }
         
        }

        private static void CaseStudy2()
        {
           HashSet<int> scores = new HashSet<int>();
           scores.Add(10);
            scores.Add(20);
            scores.Add(301);

            scores.Add(10);
            scores.Add(20);
            scores.Add(301);

            scores.Add(3);
            Console.WriteLine(scores.Count);
            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }
        }

        private static void CaseStudy1()
        {
            HashSet<string> userName = new HashSet<string>();
            userName.Add("Ekta");
            userName.Add("Ankit");
            userName.Add("Subran");
            userName.Add("Subran");
            userName.Add("ekta");
            Console.WriteLine(userName.Count);
            foreach (string names in userName)
            {
                Console.WriteLine(names);
            }



        }
    }
}