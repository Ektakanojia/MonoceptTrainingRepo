using BirdRefactored.Model;

namespace BirdRefactored
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintBirdCanFlyOrNot(new Ostrich("ostrich"));
            PrintBirdCanFlyOrNot(new Pigeon("pigeon"));
            PrintBirdCanFlyOrNot(new Parrot("parrot"));

        }

        private static void PrintBirdCanFlyOrNot(IBirdCanFly bird)
        {
            Console.WriteLine("Bird Name {0},Bird can fly or not {1}", bird.Name, bird.CanFly());
            Console.WriteLine();
        }

       
    }
}