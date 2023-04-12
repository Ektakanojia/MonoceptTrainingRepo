using System;
using System.IO;

namespace FileInfoDirectoryInfoApp
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
            Console.WriteLine(".....Case study2......");
            DirectoryInfo di = new DirectoryInfo(@"c:\MyDir");
            //DirectoryInfo obj = new DirectoryInfo(@"c:\MyDir");
            if (di.Exists )
            {
                Console.WriteLine("Path already exist");
                Console.WriteLine("The of the directory"+ di.FullName);

            }
            di.Create();
            Console.WriteLine("Directory has created successfully");
            
        }

        private static void CaseStudy1()
        {
            Console.WriteLine(".........case study1...........on fileInfo");
            FileInfo fi = new FileInfo(@"C:\MonoceptTraning\March\assignment12\PigDiceObjectCalisthnic");
            Console.WriteLine("Full name:" + fi.FullName);
            Console.WriteLine("File name:" + fi.Name);
            Console.WriteLine("File creation time:" + fi.CreationTime);
            Console.WriteLine("File last edited time:" + fi.LastWriteTime);
            Console.WriteLine("File exist:" + fi.Exists);
            Console.WriteLine("File attribute:" + fi.Attributes);
            Console.WriteLine(fi.GetType().FullName);

        }
    }
}
