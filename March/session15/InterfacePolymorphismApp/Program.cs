using InterfacePolymorphismApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePolymorphismApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Man man;
            man = new Man();
            Boy boy;
            boy = new Boy();

            AtTheParty(man);
            AtTheParty(boy);
            AtTheCinemaHall(boy);
            AtTheCinemaHall(man);

        }
         
        public static void AtTheParty(IMannerable obj)
        {
            Console.WriteLine("At the party hall");
            obj.Depart();
            obj.Wish();
            Console.WriteLine("party end");
        }

        public static void AtTheCinemaHall(IEmotionable obj)
        {
            Console.WriteLine("cinema hall");
            obj.Laugh();
            obj.Cry();
            Console.WriteLine("end");
        }
    
    }
}
