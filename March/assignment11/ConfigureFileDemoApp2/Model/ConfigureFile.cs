using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigureFileDemoApp2.Model
{
    internal class ConfigureFile
    {
        public  void AppConfig()
        {
            string serve1722391144 = System.Configuration.ConfigurationManager.AppSettings["connection2"];
            string AurionProDb = System.Configuration.ConfigurationManager.AppSettings["database2"];
            string sa = System.Configuration.ConfigurationManager.AppSettings["sa"];
            string pass123 = System.Configuration.ConfigurationManager.AppSettings["pass123"];
           
        }
        public string DataBase
        {
            get
            {
                return value;
            }
        }
    }
}
