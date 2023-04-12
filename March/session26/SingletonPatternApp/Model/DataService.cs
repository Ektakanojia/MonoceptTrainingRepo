using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternApp.Model
{
    internal class DataService
    {
        //public Dataservice() 
        //{
        //    console.writeline("data service created");
        //}
        private DataService()
        {
            Console.WriteLine("data service created");
        }
        public void DoProcessing()
        {
            Console.WriteLine("Processing Data By" + this.GetHashCode());
        }
        public static DataService GetInstance() { return new DataService(); }
    }
}
