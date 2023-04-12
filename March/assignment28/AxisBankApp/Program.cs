using AxisBankFDApp.Model;
using FixedDepositeCoreLib.Model;

namespace AxisBankApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FixedDeposite fixedDeposite = new FixedDeposite(101, "Ekta", 1000, 3,new DCalculateRate(DiwaliRatePolicy.CalculateRate));
            Console.WriteLine(fixedDeposite.SimpleIntrest);
            FixedDeposite fixedDeposite1= new FixedDeposite(102,"Smiriti",2000,4,new DCalculateRate(NewYearRatePolicy.CalculateRate))
        }
    }
}