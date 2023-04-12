namespace SimpleDelegateApp
{
    internal class Program
    {
        delegate void DPrintMessage(string name);
        static void Main(string[] args)
        {
            CaseStudy1();
            PrintWizard(PrintHello);
            PrintWizard(PrintGoodBye);
            CaseStudy2();
            CaseStudy3();
            CaseStudy4();
        }

        private static void CaseStudy4()
        {
            DPrintMessage x;
            //x = printhello;
            //x = delegate (string name) { };

            x = (n) => Console.WriteLine("lambda {0}", n);
            //invoking the object
            x("Ekta");
        }

        //lambda function
        private static void CaseStudy3()
        {
            PrintWizard(( name)=>
            {
                Console.WriteLine("Anoymous object");
                Console.WriteLine("champ");
            });
        }

        //anonymous objects
        private static void CaseStudy2()
        {
            PrintWizard(delegate (string name)
            {
                Console.WriteLine("Anoymous object");
                Console.WriteLine("champ");
            });
        }

        private static void CaseStudy1()
        {
            DPrintMessage obj = PrintHello;
            obj += PrintGoodBye;
            obj += PrintHello;
            //obj += Foo;
            obj("Ekta");
            obj("Ankit");
        }

        static void PrintWizard(DPrintMessage fptr)
        {
            Console.WriteLine("Doing printing operation");
            Console.WriteLine("operation completed");
            fptr("Champ");
        }
        static void PrintHello(string name)
        {
            Console.WriteLine("Hello {0}", name);
        }
        static void PrintGoodBye(string name)
        {
            Console.WriteLine("Good Bye {0}", name);
        }
        static void Foo() { Console.WriteLine("inside foo"); }
    }
}