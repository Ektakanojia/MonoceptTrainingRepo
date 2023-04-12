using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePolymorphismApp.Model
{
    internal class Boy : IEmotionable,IMannerable
    {
        public void Cry()
        {
            Console.WriteLine(" Boy is Cry");
        }

        public void Depart()
        {
            Console.WriteLine(" Booy is Depart");
        }

        public void Laugh()
        {
            Console.WriteLine(" Boy is Laugh");
        }

        public void Wish()
        {
            Console.WriteLine(" Boy is Wish");
        }
    }
}
