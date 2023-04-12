using SingletonPatternApp.Model;

namespace SingletonPatternApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Service1 = DataService.GetInstance();
            Service1.DoProcessing();

            var Service2 = DataService.GetInstance();
            Service2.DoProcessing();

            var Service3 = DataService.GetInstance();
            Service3.DoProcessing();

            Console.WriteLine("service1 hashcode" + Service1.GetHashCode());
            Console.WriteLine("service2 hashcode" + Service2.GetHashCode());
            Console.WriteLine("service3 hashcode" + Service3.GetHashCode());
        }
    }
}