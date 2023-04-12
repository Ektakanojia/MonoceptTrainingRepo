using RefelectionApp.Model;

namespace RefelectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomAttribute.DisplayCustomAttributes(typeof(Employer));
            Console.WriteLine();
            CustomAttribute.DisplayCustomAttributes(typeof(Employee));
        }
    }
}