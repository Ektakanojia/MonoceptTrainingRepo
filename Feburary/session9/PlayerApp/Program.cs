using PlayerApp.Model;
using System;


namespace PlayerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1(); 
            CaseStudy2();
            CaseStudy3();

        }
        //creating a palyer array.
        private static void CaseStudy3()
        {
            Player sachin = new Player(1, "sachin", 15);
            Player[] manyPlayer=new Player[5];
            manyPlayer[0] = new Player(1, "Player1", 20);
            manyPlayer[1] = sachin;
            manyPlayer[2] = sachin;
            manyPlayer[3] = sachin;
            manyPlayer[4] = sachin;
            foreach (Player player in manyPlayer)
            {
                PrintDetailes(player, "");
            }

        }

        private static void CaseStudy2()
        {
            Player sachin = new Player(1, "sachin", 15);
            Player virat = new Player(2, "virat");
            Player elder = sachin.WhoIsElder(virat);

            Console.WriteLine(elder.Name);
            Console.WriteLine("sachin hash"+sachin.GetHashCode());
            Console.WriteLine("virat hash"+virat.GetHashCode());
            Console.WriteLine("elder hash"+elder.GetHashCode());
        }

        private static void CaseStudy1()
        {
            Player playerA = new Player(1, "sachin", 50);
            Player playerB = new Player(2, "virat");

            PrintDetailes(playerA, "Details of palyer A");
            PrintDetailes(playerB, "Details of palyer B");
        }

        static void PrintDetailes(Player player,string title="")
        {
            Console.WriteLine("id is:"+player.Id);
            Console.WriteLine("name is: " + player.Name);
            Console.WriteLine("age is:" + player.Age);

        }
        
    }
}
