using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdApp.Model
{
    internal class Pigeon:Bird
    {
        public Pigeon(string pname) : base(pname) { } 
        public override  string Fly()
        {
            return ("I am a pigeon and I can fly");          
        }
    }
}
