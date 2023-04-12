using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintName("Ekta kanojia", 10);
            bool result = CheckIsEven(3);
            Console.WriteLine("checkIsEven :" + result);
            Console.WriteLine("checkIsEven2:" + CheckIsEven2(4));
            Console.WriteLine("checkIsEven2:" + CheckIsEven2(5));
            PrintTodaysDate();
            string[] developerNames = GetDeveloperNames();
            foreach(string name in developerNames)
            {
                Console.WriteLine(name.ToUpper());
            }
            /* Console.WriteLine("Enter Your name");
             string userName= Console.ReadLine();
             Console.WriteLine("Welcome"+userName.ToUpper());*/
            RollDice(5);
        }
        static void RollDice(int num)
        {
            Random rand = new Random();
            for(int i=0;i<num;i++)
            {
                Console.WriteLine("random number Generated :" + rand.Next(1,6));
            }

        }
        static void PrintTodaysDate()
        {
            Console.WriteLine(DateTime.Now.ToString("M"));
        }
        static string[] GetDeveloperNames()
        {
            string[] name = { "Ekta", "Ankit", "Adii", "Subham", "Subran" };
            return name;
        }
        static bool CheckIsEven(int values)
        {
            if (values % 2 == 0)
                return true;
            else
                return false;
        }
        static string CheckIsEven2(int values)
        {
            return (values % 2 == 0) ? "Input  value is even" : "Input Value is ODD";
        }
        static bool CheckIsEven3(int values)
        {
            if (values % 2 == 0) return true;
            return false;
        }
        static void PrintName(string userName, int level)
        {
            for (int i = 0; i < level; i++)
            {
                Console.WriteLine(userName.ToUpper());
            }

        }
    }
}
