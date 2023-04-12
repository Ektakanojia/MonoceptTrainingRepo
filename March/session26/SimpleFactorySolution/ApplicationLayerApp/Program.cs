using FactoryCoreLib.Factory;

namespace ApplicationLayerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoMobileFactory factory = new AutoMobileFactory();
            IAutomobile auto = factory.Make(AutoEnumOptions.TESLA);
            auto.Start();
            auto.Stop();
            Console.WriteLine(auto.GetType());

        }
    }
}