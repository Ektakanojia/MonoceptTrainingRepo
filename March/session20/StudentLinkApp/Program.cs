using StudentLinkApp.Model;

namespace StudentLinkApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // LinkedList<string> list = new LinkedList<string>();
           Student students = new Student();
            Student manjunath = new Student { Name = "ManjuNath" };
            Student ekta = new Student { Name = "Ekta" };
            Student ravi = new Student { Name = "ravi" };
            Student shubh = new Student { Name = "shubh" };

            manjunath.Buddy = ekta;
            ekta.Buddy = ravi;
            ravi.Buddy = shubh;
            shubh.Buddy = null;
           
            PrintDetails(manjunath);


        }

        private static void PrintDetails(Student student)
        {
          
            while( student.Buddy != null ) 
            {
                Console.WriteLine(student.Name);
                student = student.Buddy;

            }
           
        }
    }
}