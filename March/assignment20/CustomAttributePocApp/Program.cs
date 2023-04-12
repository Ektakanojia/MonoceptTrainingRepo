using CustomAttributePocApp.Model;

namespace CustomAttributePocApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.setDetails(1, "Ankit", 23);

            Console.WriteLine("Details of student");

            Console.WriteLine("id :"+student.getId());
            Console.WriteLine("Name:"+ student.getName());
            Console.WriteLine("Age:"+ student.getAge());

        }
    }
}