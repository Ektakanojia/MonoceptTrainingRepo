using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdApp.Model
{
    internal class Parrot:Bird
    {
        public Parrot(string name) : base(name)
        {
        }

        public override string Fly()
        {
            return ("I am Parrot and I can Fly");
        }
    }
}
