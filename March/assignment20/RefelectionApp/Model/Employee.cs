using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefelectionApp.Model
{
    public class Employee
    {
        private int _id;
        private string _name;

        public Employee(int id,string name) 
        { 
        _id=id;
        _name = name;

        }
        [CustomAttribute("Accessor","Give Employee Id")]
        public int getId() { return _id; }

        [CustomAttribute("Accessor","Give Employee Name")]
        public string getName() { return _name; }
    }
}
