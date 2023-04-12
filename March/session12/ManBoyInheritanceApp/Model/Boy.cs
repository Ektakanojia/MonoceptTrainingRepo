using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInheritanceApp.Model
{
    internal class Boy:Man
    {
        public void Eat()
        {
            Console.WriteLine("boys eat burger");
        }
        public override void Play()
        {
            Console.WriteLine("Boy Play a cricket ");
        }
    }
}
