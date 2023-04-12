using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributeApp.Model
{
    internal class NeedToRefactor:Attribute
    {
        private string _name;
        private string _description;

        public NeedToRefactor(string name, string description)
        {
            _name = name;
           
            _description = description;
        }

        public static void DisplayNeedToRefactorAttribute(Type classType)
        {
            Console.WriteLine("Method of the class that need to be refactor {0}", classType.Name);
            //array for storing the method on whic having attribute
            MethodInfo[] methods= classType.GetMethods();
            for(int i=0;i<methods.GetLength(0);i++)
            {
                object[] attributeArray = methods[i].GetCustomAttributes(true);

                foreach(Attribute item in attributeArray)
                {
                 
                    if(item is NeedToRefactor)
                    {
                        NeedToRefactor needToRefactor = (NeedToRefactor)item;
                        Console.WriteLine("{0}-{1},{2}", methods[i].Name,needToRefactor._name,needToRefactor._description);
                    }
                }
            }
        }
    }
}
