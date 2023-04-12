using MovieLibraryApp;
using System.Runtime.Serialization.Formatters.Binary;

namespace MovieSerilizationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudySerilization();
            CaseStudyDeserilization();
        }

        private static void CaseStudyDeserilization()
        {
            FileStream fs = new FileStream("Movie1.dump", FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Object obj = binaryFormatter.Deserialize(fs);
            //MovieLibs movie = obj as MovieLibs;
            Console.WriteLine(movie.MovieName);
            Console.WriteLine(movie.MovieYear);
            fs.Close();
        }

        private static void CaseStudySerilization()
        {
            List<MovieLib> movieLibs = new List<MovieLib>();
            movieLibs.Add(new MovieLib("Race", 2012));
            FileStream fs = new FileStream("Movie1.dump", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, movieLibs);
            fs.Close();
            Console.WriteLine("Serilazation done");

        }
    }
}