using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RefelectionApp.Model
{
    public class CustomAttribute:Attribute
    {
        //fields
        private string _name;
        private string _description;
        // constructor
        public CustomAttribute(string name, string description)
        {
            _name = name;
            _description = description;
        }

        //create a methods to display the fields of custom attribute using refelection

        public static void DisplayCustomAttributes(Type classType)
        {
            Console.WriteLine("methods of class {0}",classType.Name);
            //create a array to store all the method of a class to which attribute is applied

            MethodInfo[] methods= classType.GetMethods();
            for(int i=0;i<methods.GetLength(0);i++)
            {
                object[] attributeArray= methods[i].GetCustomAttributes(true);

                foreach(Attribute item in attributeArray)
                {
                    if(item is CustomAttribute)
                    {
                        CustomAttribute attributeObject = (CustomAttribute)item;
                        Console.WriteLine("{0}-{1},{2}" , methods[i].Name,attributeObject._name,attributeObject._description);
                    }
                }
            }
        }


    }
}
