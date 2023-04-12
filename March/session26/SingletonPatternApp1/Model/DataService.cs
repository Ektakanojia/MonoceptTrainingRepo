using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternApp.Model
{
    internal class DataService
    {
        private static DataService _instance;
        private DataService()
        {
            Console.WriteLine("data service created");
        }
        public void DoProcessing()
        {
            Console.WriteLine("Processing Data By" + this.GetHashCode());
        }
        public static DataService GetInstance()
        {
            if(_instance==null)
            {
                _instance = new DataService();
            }
            return _instance;
        }
    }
}
