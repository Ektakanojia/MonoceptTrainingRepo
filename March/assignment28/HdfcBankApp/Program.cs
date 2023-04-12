using FixedDepositeCoreLib.Model;
using HDFCBankFDApp.Model;

namespace HdfcBankApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FixedDeposite fixedDeposite = new FixedDeposite(1002, "Ankit", 2300, 5, new DCalculateRate(Quater1Policy.CalculateRate));
            Console.WriteLine(fixedDeposite.SimpleIntrest);
            FixedDeposite fixedDeposite1 = new FixedDeposite(1003,"Subham",50000,6, new DCalculateRate(Quater2Policy.CalculateRate));
            Console.WriteLine(fixedDeposite1.SimpleIntrest);
        }
    }
}