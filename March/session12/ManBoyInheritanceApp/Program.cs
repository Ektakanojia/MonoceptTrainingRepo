using ManBoyInheritanceApp.Model;
using System;


namespace ManBoyInheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //created the object of man class and access it method.
            CaseStudy1();
            CaseStudy2();
            CaseStudy3();
            CaseStudy4();
            CaseStudy5();


        }

        private static void CaseStudy5()
        {
            Console.WriteLine(".......caseStudy5......");
            object box;
            box = 10;
            Console.WriteLine(box.GetType());
            box = "hello";
            Console.WriteLine(box.GetType());
            box = new Man();
            Console.WriteLine(box.GetType());
            Man man=(Man)box;
            man.Play();
            man.Read();
        }

        private static void CaseStudy4()
        {
            Console.WriteLine(".......caseStudy4......");
            AtThePark(new Man());
            AtThePark(new Boy()); 
            AtThePark(new Kid()); 
            AtThePark(new Infant());
          
        }
        private static void AtThePark(Man man)
        {
            
            Console.WriteLine("At the park");
            man.Play();
        }
        private static void CaseStudy3()
        {
            Console.WriteLine(".......caseStudy3......");
            Man x;
            x= new Man();
            x.Play();
            x.Read();
        }

        private static void CaseStudy2()
        {
            Console.WriteLine(".......caseStudy2......");
            Boy boy;
            boy = new Boy();
            boy.Eat();
            boy.Play();
            boy.Read();
            
        }

        private static void CaseStudy1()
        {
            Console.WriteLine(".......caseStudy1......");
           // Man x;// man accepts the object of man type;
            Man man; //
            man= new Man();
            man.Play();
            man.Read();

        }
    }
}
