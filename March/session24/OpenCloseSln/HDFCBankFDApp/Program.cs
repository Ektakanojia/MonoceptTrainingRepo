using FixedDepositeCoreLib.Model;
using HDFCBankFDApp.Model;

namespace HDFCBankFDApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
        }

        private static void CaseStudy1()
        {
            Quater1Policy quater1Policy = new Quater1Policy();
            FixedDeposite fixedDeposite = new FixedDeposite(1001, "Ekta", 10000, 1, quater1Policy);
            Console.WriteLine(fixedDeposite.SimpleIntrest);
            Console.WriteLine();
            Quater2Policy quater2Policy = new Quater2Policy();
            FixedDeposite fixedDeposite1 = new FixedDeposite(1002, "Ankit", 20000, 5, quater2Policy);
            Console.WriteLine(fixedDeposite1.SimpleIntrest);
        }
    }
}