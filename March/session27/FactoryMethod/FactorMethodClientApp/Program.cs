using FactoryCoreLib.Factory;
//using factorycorelib.factory.product;

namespace FactorMethodClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();

        }



        private static void CaseStudy1()
        {
            IAutomobileFactory factory1 = new TeslaFactory();
            IAutomobile auto = factory1.Make();
            auto.Start();
            auto.Stop();
        }
    }
}