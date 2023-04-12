using RectangleApp.Model;

using System;


namespace ReactangleEncapsulationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            Console.WriteLine("displaying the anonymous object");
            Console.WriteLine(new Rectangle().CalculateArea());
            PrintDetails(new Rectangle(), "anonymous object2");
            // PrintDetails(null, null);
            Rectangle rect = null;
            /*Rectangle rect;
            rect =new Rectangle ();*/
            rect.SetWidth(100);
            rect.SetHeight(100);
            PrintDetails(rect, "Rect object");


        }
        static void PrintDetails(Rectangle rectangle,string des)
        {
            Console.WriteLine(des.ToUpper());
            Console.WriteLine($"width is {rectangle.GetWidth()}");
            Console.WriteLine($"height is {rectangle.GetHeight()}");
           // Console.WriteLine($"color is {rectangle.GetColor()}");
        }
    }
}
