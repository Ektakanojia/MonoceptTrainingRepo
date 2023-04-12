using ISPSolutionApp.Model;

namespace ISPSolutionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bot = new Robot();
            var manager = new Manager();
           // AtTheCafetaria(bot);
            AtTheCafetaria(manager);
            AtWorkStation(bot);
            AtWorkStation(manager);
        }

        private static void AtWorkStation(IWalkAble walk)
        {
            Console.WriteLine("At work station");
            walk.StartWork();
            walk.StopWork();
        }

        private static void AtTheCafetaria(IEatAble eat)
        {
            Console.WriteLine("At Cafetaria");
             eat.StopEat();
             eat.StartEat();
        }
    }
}