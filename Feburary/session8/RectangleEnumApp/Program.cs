using System;
using RectangleEnumApp.Model;


namespace RectangleEnumApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
        }

        private static void CaseStudy2()
        {
            Rectangle rectangle = new Rectangle(20, 30, ColorOption.BLUE);
            PrintDetails(rectangle, "Details of rectangle");
        }

        private static void CaseStudy1()
        {
            Rectangle rectangle = new Rectangle(200, 300, ColorOption.GREEN,BorderOptioncs.SINGLELINE);
            PrintDetails(rectangle, "Details of rectangle");
        }


        static void PrintDetails(Rectangle rectangle, string title)
        {
            Console.WriteLine(title.ToUpper());
            Console.WriteLine("widht :" + rectangle.Width);
            Console.WriteLine("height:" + rectangle.Height);
            Console.WriteLine("color :" + rectangle.Color);
            Console.WriteLine("borderStyle:" + rectangle.Border);
            Console.WriteLine();
        }
    }
}
