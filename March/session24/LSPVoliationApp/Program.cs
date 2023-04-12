using LSPVoliationApp.Model;

namespace LSPVoliationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShouldNotChangeHeigth_IfWidthIsModified(new Rectangle(100, 20)); 
            ShouldNotChangeHeigth_IfWidthIsModified(new Square(50));

        }

        private static void ShouldNotChangeHeigth_IfWidthIsModified(Rectangle rectangle)
        {
            int beforeChange= rectangle.GetHeight();
            rectangle.SetWidth(rectangle.GetWidth() + 10);
            int afterChange= rectangle.GetHeight();
            Console.WriteLine(beforeChange == afterChange);
            Console.WriteLine(beforeChange);
            Console.WriteLine(afterChange);
        }
    }
}