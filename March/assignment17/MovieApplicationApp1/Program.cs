using MovieApplicationApp1.Model;

namespace MovieApplicationApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("..............Welcome to Movie store.............");
            MovieStore movieStore= new MovieStore();
            DisplayMenu(movieStore);
             
            
        }
        public static void DisplayMenu(MovieStore movieStore)
        {
            int choice;
            Console.WriteLine("Enter 1 For Adding the movie ");
            Console.WriteLine("Enter 2 for Display the movies ");
            Console.WriteLine("Enter 3 for Exiting the movie ");
            choice = UserChoice();
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Add the movie");
                        
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("Display the movie");
                       
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Exit");
                       
                        break;
                    }
            }


        }

        public static int UserChoice()
        {
            string input = "@";
            Console.WriteLine("Enter the choice");
            input = Console.ReadLine();
            int userchoice = Int32.Parse(input);
            return userchoice;
        }



    }
}