using ISPVolationApp.Model;

namespace ISPVolationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bot = new Robot();
            var manager = new Manger();
            AtWorkstation(bot);
            AtWorkstation(manager);
            AtTheCafetria(bot);


        }

        private static void AtTheCafetria(IWorker worker)
        {
            Console.WriteLine("at cafetria");
            worker.StartWork();
            worker.StopWork();
        }

        private static void AtWorkstation(IWorker worker)
        {
            Console.WriteLine("at work station");
            worker.StartWork();
            worker.StopWork();
        }

    }
}