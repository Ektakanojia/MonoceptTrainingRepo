using FactoryCoreLib.Factory;

namespace SimpleFactoryWithSingletonPatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factory1 = AutoMobileFactory.Instance;
            var auto = factory1.Make(AutoEnumOptions.AUDI);
            auto.Start();
            auto.Stop();
            auto = factory1.Make(AutoEnumOptions.BMW);
            auto.Start();
            auto.Stop();
            var factory2 = AutoMobileFactory.Instance;
            var auto2 = factory2.Make(AutoEnumOptions.TESLA);
            auto2.Start();
            auto2.Stop();

            Console.WriteLine(factory1 == factory2);
        }
    }
}