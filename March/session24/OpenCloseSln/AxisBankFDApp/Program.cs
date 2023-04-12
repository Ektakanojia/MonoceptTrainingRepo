using AxisBankFDApp.Model;
using FixedDepositeCoreLib.Model;

namespace AxisBankFDApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DiwaliRatePolicy diwaliRatePolicy = new DiwaliRatePolicy();
            FixedDeposite fixedDeposite = new FixedDeposite(1003, "Ankit", 30000, 6, diwaliRatePolicy);
            Console.WriteLine(fixedDeposite.SimpleIntrest);
            NewYearRatePolicy newYearRatePolicy= new NewYearRatePolicy();
            FixedDeposite fixedDeposite1 = new FixedDeposite(1009,"Adii",500000,7,newYearRatePolicy);
            Console.WriteLine(fixedDeposite1.SimpleIntrest);

        }
    }
}