using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefelectionApp.Model
{
     public class Employer
    {
        private int _id;
        private string _name;

        public Employer(int id ,string name) 
        { 
        _id= id;
        _name= name;
        
        }
        [CustomAttribute("Accessor", "Give Employer Id")]
        public int getId()
        {
            return _id;
        }
        [CustomAttribute("Accessor", "Give Employer Name")]
        public string getName()
        {
            return _name;
        }
    }
}
