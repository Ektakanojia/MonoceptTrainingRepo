using MovieBusinessLayerLibrary.Model;
using System.ComponentModel;
using System.Net.Http.Headers;

namespace MovieConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieStore movieStore = new MovieStore();
            Console.WriteLine("Welcome to the movie store App");
            Console.WriteLine("Avilable movies:"+movieStore.CountAvilableMovie);
            DisplayMenu(movieStore);
        }

       

        public static void DisplayMenu(MovieStore movieStore)
        {
            int choice;
            Console.WriteLine("1 Add Movie");
            Console.WriteLine("2 Display Movie");
            Console.WriteLine("3 Exit");
            choice = UserInput();
            switch (choice)
            {
                case 1:
                    while (true)
                    {
                        movieStore.AddMovie();

                        Console.Write("Do you want to add more movies? (y/n): ");
                        string answer = Console.ReadLine()!;
                        if (answer.ToLower() == "n")
                        {
                            break;
                        }
                    }
                    DisplayMenu(movieStore);
                    break;
                case 2:
                    Console.WriteLine("Display the movie");
                    movieStore.DisplayMovies();
                    break;
                case 3:
                    Console.WriteLine("Exit the screen");
                    movieStore.Exit();
                    break;
            }

        }

        private static int UserInput()
        {
            string input = "@";
            Console.WriteLine("Enter the choice");
            input = Console.ReadLine();
            int userInput = Int32.Parse(input);
            return userInput;

        }
    }
}