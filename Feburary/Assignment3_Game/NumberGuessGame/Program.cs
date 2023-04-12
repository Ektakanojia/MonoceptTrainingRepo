using System;

namespace NumberGuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("..........Welcome to the NumberGuessGame...........");
            GuessTheNumber();

        }
        static void GuessTheNumber()
        {
            Random randomNumber = new Random();
            int guessNumber;
            int numberOfGuesses;
            int newRandomNumber;
            bool playAgain = true;
            string response;
            while (playAgain)
            {
                guessNumber = 0;
                numberOfGuesses = 0;
                response = "";
                newRandomNumber = randomNumber.Next(1, 100);
                Console.WriteLine("Random Generated Number is " + ":" + newRandomNumber);
                while (guessNumber != newRandomNumber)
                {
                    Console.WriteLine("Guess the Number between 1 to 100");
                    guessNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Number Guess by user is : " + guessNumber);
                    if (guessNumber > newRandomNumber)
                    {
                        Console.WriteLine(guessNumber + " " + ":" + "Sorry To High");
                        numberOfGuesses++;
                    }
                    else if (guessNumber < newRandomNumber)
                    {
                        Console.WriteLine(guessNumber + " " + ":" + "Sorry To Low");
                        numberOfGuesses++;
                    }


                }
                Console.WriteLine("You Win");
                Console.WriteLine(numberOfGuesses + " " + "Attempt");
                Console.WriteLine("You want to play again (YES/NO)");
                response = Console.ReadLine();
                if (response == "YES")
                    playAgain = true;
                else
                    playAgain = false;

            }
            Console.WriteLine("Thanks For playing");


        }
    }
}
