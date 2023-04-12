namespace ActionFuncApp
{
     delegate bool CheckLongName(string name);
    internal class Program
    {

        static void Main(string[] args)
        {
            EvenCaseStudy();
            CaseStudy2();
            CaseStudy3();

        }

        private static void CaseStudy3()
        {
            Action<int, int> addPtr = Add;
            addPtr(10, 20);
        }

        private static void CaseStudy2()
        {
            //CheckLongName checkLong =  CheckIsLong;
            //Console.WriteLine(checkLong);
            Func<string, bool> longNameCheckPtr = CheckIsLong;
            Console.WriteLine(longNameCheckPtr("Ekta kanojia"));
        }

        private static void EvenCaseStudy()
        {
            Predicate<int> isEvenPtr = CheckEven;
            Console.WriteLine(isEvenPtr(30));
        }

        public static bool CheckEven(int num) { 
         return num%2 == 0; 
        }

        public static bool CheckIsLong(string name)
        {
            return name.Length >= 10;
               
        }

         static void Add(int num1,int num2)
        {
            Console.WriteLine(num1+num2);
        }
    }
}