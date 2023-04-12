using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationFileDemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Ekta = System.Configuration.ConfigurationManager.AppSettings["user_name"]; 
            string abc = System.Configuration.ConfigurationManager.AppSettings["password"];
            string kanojiaekta211 = System.Configuration.ConfigurationManager.AppSettings["email"];
            string cantt = System.Configuration.ConfigurationManager.AppSettings["address"];
            Console.WriteLine(Ekta+" "+abc+" "+kanojiaekta211+" "+cantt);


        }
    }
}
