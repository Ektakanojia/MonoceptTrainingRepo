using System;
namespace PigDiceGame
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
            int newRandomNumber;
            bool playAgain = true;
            string res;
            while (playAgain)
            {
                score = 0;
                totalScore = 0;
                turn = 1;
                Console.WriteLine("Turn is:" + turn);
                while (turn<=20)
                {
                    Console.WriteLine("Enter the choice");
                    string choice=Console.ReadLine();
                    if(choice == "r")
                    {
                        Random random = new Random();
                        newRandomNumber= random.Next(1,6);
                        Console.WriteLine("You rolled:" + newRandomNumber);
                        if (newRandomNumber == 1)
                        {
                            score = 0;
                            totalScore = 0;
                            Console.WriteLine("Turn over ,No score");
                            turn = turn + 1;
                            Console.WriteLine("turn is :{0}", turn);
                        }
                        else
                        {
                            score = score + newRandomNumber;
                            Console.WriteLine("Your turn score is : {0},Your total score is :{1}", score, totalScore);
                            Console.WriteLine("if you hold you have score :{0}", score);

                        }
                    }
                    else if(choice == "h")
                    {
                        totalScore = score;
                        if (totalScore >= 20)
                        {
                            Console.WriteLine("Game over ,You win");
                            Console.WriteLine("Finshed in" + turn + "turn");
                            Console.WriteLine("You want play again for yes Y and for No N");
                            res=Console.ReadLine(); 
                            if(res=="Y")
                                playAgain= true;
                            else
                                playAgain= false;


                        }
                        Console.WriteLine("Your turn score is:{0},Your total score is :{1}", score,totalScore);
                        turn = turn + 1;
                        Console.WriteLine("Turn is {0}", turn);
                    }

                }
                Console.WriteLine("Thanks for Playing");
            }

        }

    }
}
