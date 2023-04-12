using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceObjectCalisthenic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(".................Welcome to Pig Dice Game..............");
            Console.WriteLine(".................Let's Play the game.....................");
            PlayGame();

        }

        public static void PlayGame()
        {

            int score;
            int totalScore;
            int turn;
            //int newRandomNumber;
            bool playAgain = true;
           // string res;
            
            while (playAgain)
            {
                score = 0;
                totalScore = 0;
                turn = 1;
                Console.WriteLine("Turn is:" + turn);

                UserTurn(ref score, ref totalScore, ref turn); 
                Console.WriteLine("Thanks for Playing");
            }

        }

        public static void UserTurn(ref int score, ref int totalScore, ref int turn)
        {
            string res = "";
            bool playAgain=true;
            while (turn <= 20)
            {
                Console.WriteLine("Enter the choice");
                string choice = Console.ReadLine();
                UserChoice(ref score, ref totalScore, ref turn, ref res,ref playAgain, choice);

            }
        }

        private static void UserChoice(ref int score, ref int totalScore, ref int turn, ref string res, ref bool playAgain, string choice)
        {
            if (choice == "r")
            {
                UserChoiceRoll(ref score, ref totalScore, ref turn);
            }
             if (choice == "h")
            {
                totalScore = UserChoiceHold(score, ref turn, ref res, ref playAgain);
            }
        }

        private static int UserChoiceHold(int score, ref int turn, ref string res, ref bool playAgain)
        {
            int totalScore = score;
            if (totalScore >= 20)
            {
                Console.WriteLine("Game over ,You win");
                Console.WriteLine("Finshed in" + turn + "turn");
                Console.WriteLine("You want play again for yes Y and for No N");
                res = Console.ReadLine();
                if (res == "Y")
                    playAgain = true;
                else
                    playAgain = false;


            }
            Console.WriteLine("Your turn score is:{0},Your total score is :{1}", score, totalScore);
            turn = turn + 1;
            Console.WriteLine("Turn is {0}", turn);
            return totalScore;
        }

        private static void UserChoiceRoll(ref int score, ref int totalScore, ref int turn)
        {
            Random random = new Random();
            int newRandomNumber = random.Next(1, 6);
            Console.WriteLine("You rolled:" + newRandomNumber);
            if (newRandomNumber == 1)
            {
                score = 0;
                totalScore = 0;
                Console.WriteLine("Turn over ,No score");
                turn = turn + 1;
                Console.WriteLine("turn is :{0}", turn);
            }
           
                score = score + newRandomNumber;
                Console.WriteLine("Your turn score is : {0},Your total score is :{1}", score, totalScore);
                Console.WriteLine("if you hold you have score :{0}", score);

            
        }
    }
}
