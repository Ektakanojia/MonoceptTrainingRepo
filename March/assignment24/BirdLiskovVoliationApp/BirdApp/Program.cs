using BirdApp.Model;

namespace BirdApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ItSholudFly(new Parrot("parrot"));
            ItSholudFly(new Pigeon("pigeon"));
            ItSholudFly(new Ostrich("ostrich"));
        }

        private static void ItSholudFly(Bird bird)
        {
            Console.WriteLine(bird.Fly());
            Console.WriteLine();
        }
    }
}