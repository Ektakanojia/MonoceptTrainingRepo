using System;
using System.IO;
//for using the streamreader and streamwriter we need to add System.IO

namespace StreamReaderWriterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FileName = "TextFile.txt";
            //calling the writetofile method.
            WriteToFile(FileName);
            //calling the readfromfile method.
            ReadFromFile(FileName);
            
        }
        //using stream reader to read the content from text file.
        //Read From File method
        public static void ReadFromFile(string fileName)
        {
            //create a stream reader object that take file name as agrument
            //As along as there is line it will execute the while loop.
            //inside the while loop it will read the line and written is to the console.
            //once line is finshied we need to close the reader object.
            StreamReader reader = new StreamReader(fileName);
            while (!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());
            }
            reader.Close();
        }
        //using stream writer to write the content in a text file.
        //Write From File method.
        public static void WriteToFile(string fileName)
        {
            //create a stream writer object and pass two argument  one file path amd other is ture so that it can append the content true.
            StreamWriter writer = new StreamWriter(fileName, true);
            //create the variable to hold the user input and set it to empty intially
            string temp = string.Empty;
            do
            {
                Console.Write("add the content to file and add -1 to exit :");
                temp = Console.ReadLine();
                if (temp != "-1")
                {
                    writer.WriteLine(temp);
                }

            } while (temp != "-1");
            writer.Close();
        }

    }
}
