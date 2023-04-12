using OCPVoliationApp.Model;

namespace OCPVoliationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FixedDeposite fd1 = new FixedDeposite(1001, "Ekta", 100000, 10, FestivleType.NORMAL);
            Console.WriteLine(fd1.SimpleIntrest);
        }
    }
}