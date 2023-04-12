using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributePocApp.Model
{
    [AttributeUsage(AttributeTargets.All)]
     public class CustomAttribute:Attribute
    {
        private string _name;
        private string _description;

        public CustomAttribute(string name, string description)
        {
          this._name = name;
          this._description = description;
        }

        public string Name
        {
            get { return _name; }
        }
        public string Description { 
            get { return _description; }
        }
    }
}
