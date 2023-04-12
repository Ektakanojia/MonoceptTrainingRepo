using System.Collections.Immutable;

namespace CheckAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            CaseStudy3();

        }


        private static void CaseStudy3()
        {
            string s1 = "GraceMark";
            string s2 = "HEART";
            CheckAnagram(s1, s2);
        }

        private static void CaseStudy2()
        {
            string s1 = "EARTH";
            string s2 = "HEART";
            CheckAnagram(s1, s2);
        }

        private static void CaseStudy1()
        {
            string s1 = "earth";
            string s2 = "heart";
            CheckAnagram(s1, s2);
        }

        private static void CheckAnagram(string s1, string s2)
        {
            char[] arr1 = s1.ToLower().ToCharArray();
            char[] arr2 = s2.ToLower().ToCharArray();
            Array.Sort(arr1);
            Array.Sort(arr2);
            if (arr1.Length != arr2.Length)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not a anagram because of different length");
                Console.ResetColor();

            }
            else
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Not a anagram");
                        break;
                    }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Yes Both the string are anagram");
                Console.ResetColor();

            }
            Console.WriteLine();
        }
    }
}