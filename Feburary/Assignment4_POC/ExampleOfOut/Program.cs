using System;


namespace ExampleOfOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName;
            string studentCourse;
            int studentId;
            long  studentPhoneNumber;
            //Example of out
            GetTheStudentDetails(out studentName,out studentCourse,out studentId,out studentPhoneNumber);
            //Example of In
            int number =90;
            ExampleOfIn(number);
        }
        private static void GetTheStudentDetails(out string studentName,out string studentCourse,out int studentId,out long  studentPhoneNumber)
        {
            studentName = "Ankit";
            studentCourse = "MCA";
            studentId = 20223036;
            studentPhoneNumber = 9876543321;
            Console.WriteLine("studentname: {0},studentCourse:{1},studentId:{2},studentPhoneNumber", studentName, studentCourse, studentId,studentPhoneNumber);

        }
        private static void ExampleOfIn(in int updatedNumber)
        {
             //updatedNumber = 22;
            Console.WriteLine(updatedNumber);
        }
        
    }
}
