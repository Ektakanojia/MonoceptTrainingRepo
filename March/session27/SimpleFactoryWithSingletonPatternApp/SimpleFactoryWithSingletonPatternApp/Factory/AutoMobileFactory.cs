using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCoreLib.Factory
{
    public class AutoMobileFactory
    {
        private static AutoMobileFactory _instance;

        public AutoMobileFactory() { }
        public IAutomobile Make(AutoEnumOptions auto)
        {
            if (auto == AutoEnumOptions.BMW)
            {
                return new Bmw();
            }
            else if (auto == AutoEnumOptions.TESLA)
            {
                return new Tesla();
            }
            else
                return new Audi();
        }

        public static AutoMobileFactory Instance
        {
            get
            {
             if( _instance == null)
                {
                    _instance = new AutoMobileFactory();
                }  
             return _instance;
            }
        }
    }
}
