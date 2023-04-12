using SingletonPatternApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingletonWithMultiThread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Application.Run(new DataService());
        }
    }
}
