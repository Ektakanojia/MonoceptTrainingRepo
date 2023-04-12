using ConfigureFileDemoApp2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigureFileDemoApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            CaseStudy2();
        }

        private static void CaseStudy2()
        {
            ConfigureFile config = new ConfigureFile();
            config.AppConfig();
            PrintDetails(config, "Data base Details");
        }
        public static void PrintDetails(ConfigureFile config, string title)
        {
            Console.WriteLine(title.ToUpper());
            Console.WriteLine(config.DataBase);
        }

       
    }
}
