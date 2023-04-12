using SingletonPatternApp.Model;

namespace SingletonPatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CaseStudy1();
            CaseStudy2();
        }

        private static void CaseStudy2()
        {
            var Service1 =  DataService.GetInstance();
            Service1.DoProcessing();

            var Service2 =  DataService.GetInstance();
            Service2.DoProcessing();

            var Service3 =  DataService.GetInstance();
            Service3.DoProcessing();

            Console.WriteLine("service1 hashcode" + Service1.GetHashCode());
            Console.WriteLine("service2 hashcode" + Service2.GetHashCode());
            Console.WriteLine("service3 hashcode" + Service3.GetHashCode());
        }

        //private static void CaseStudy1()
        //{
        //    var Service1 = new DataService();
        //    Service1.DoProcessing();

        //    var Service2 = new DataService();
        //    Service2.DoProcessing();

        //    var Service3 = new DataService();
        //    Service3.DoProcessing();

        //    Console.WriteLine("service1 hashcode" + Service1.GetHashCode());
        //    Console.WriteLine("service2 hashcode" + Service2.GetHashCode());
        //    Console.WriteLine("service3 hashcode" + Service3.GetHashCode());
        //}
    }
}