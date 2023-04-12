using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp.Model
{
    internal class Player
    {
        private int id;
        private string name;
        private int age;

        public Player(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        /*public Player(int id,string name)
        {
            this.id = id;
            this.name = name;
            this.age = 18;
        }*/
        /*: means before hitting this line it will go to 3 params constructor.
         *  refactoring is done here .
         */
        public Player(int id,string name) : this(id, name, 18)
        {
            Console.WriteLine("inside 2 params");
        }
        public Player  WhoIsElder(Player secondplayer)
        {
         return this.age>secondplayer.age?this:secondplayer;
        }
        public int Id
        {
            get
            {
                return id;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
        }
    }
   

}
