using DictonaryApp.Model;

namespace DictonaryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            var s1 = new Student { Name="Ravi",Id= 1 ,Standard=11}; 
            var s2 = new Student { Name="Ankit",Id= 2 ,Standard=11};      
            var s3 = new Student { Name="Ravi",Id= 2 ,Standard=11};

            Console.WriteLine("Value Equality s1 and s3",s1.Equals(s3));
            Console.WriteLine("Hashcode s1 and s3",s1.GetHashCode()==s3.GetHashCode()); 
            Console.WriteLine("Refferintial Equality:",(s1==s3));

            var students = new Dictionary<Student, Student>();
            students.Add(s1, s1);
            students.Add(s2, s2);
            students.Add(s3, s3);

            Console.WriteLine(students.Count);
        }

        private static void CaseStudy1()
        {
           Dictionary<string ,string> stateCodes = new Dictionary<string ,string>();
            stateCodes.Add("MP", "Madhya Pardesh");
            stateCodes.Add("UP", "Uttar Pardesh");
            stateCodes.Add("KL", "Kerela");
            stateCodes.Add("KA", "Karnatak");
            if (stateCodes.ContainsKey("KL"))
            {
                stateCodes.Remove("KL");
                stateCodes.Add("KL", "NEW KERELA");

            }

            Console.WriteLine(stateCodes.Count);

            foreach(var row in stateCodes) 
            { 
                Console.WriteLine("key is {0} -value is{1}",row.Key,row.Value);
            }
            stateCodes["UP"] = "New Uttar Pardesh";
            Console.WriteLine(stateCodes["UP"]);
        }
    }
}