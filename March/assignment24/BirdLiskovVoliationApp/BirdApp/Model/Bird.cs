using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdApp.Model
{
    public class Bird
    {
        protected string _name;

        public Bird(string name) 
        { 
        _name= name;
        
        }
        public virtual string  Fly()
        {
            return ("I am a bird");
        }

    }
}
