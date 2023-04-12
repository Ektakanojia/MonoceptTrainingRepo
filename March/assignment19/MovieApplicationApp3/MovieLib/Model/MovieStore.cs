using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MovieBusinessLayerLibrary.Model
{
    [Serializable]
    public class MovieStore
    {
        //create a array of constructor type
        private Movie[] movies;
        private int countAvialableMovies;

       
        public MovieStore() 
        {
            countAvialableMovies= 0;
            movies = new Movie[0];
            //SerilizeFile();
            Deserilize();
        }

        
        public  void AddMovie()
        {

            string name;
            int year;
            Console.WriteLine("Enter the name of the movie");
            name = Console.ReadLine();
            Console.WriteLine("Enter the Year of the movie");
            string movieYear = Console.ReadLine();
            year = int.Parse(movieYear);

            if (countAvialableMovies == movies.Length)
            {
                Array.Resize(ref movies, movies.Length+1);
            }

            movies[countAvialableMovies] = new Movie { Name = name, Year = year };
            countAvialableMovies++;
            Console.WriteLine("Movie Added");
            SerilizeFile();
            Deserilize();

        }

       
        //save
        private void SerilizeFile()
        {
            FileStream fileStream = new FileStream("MovieRecords.dump", FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, movies);
            fileStream.Close();
            Console.WriteLine("Serilazation Done");
         
        }
        //load
        private void Deserilize()
        {
            FileStream fileStream = new FileStream("MovieRecords.dump", FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            Object obj = formatter.Deserialize(fileStream);
            Movie[] m = obj as Movie[];
            movies = m;
            countAvialableMovies= movies.Length;
            fileStream.Close();
        }

        public void DisplayMovies()
        {
            if (countAvialableMovies == 0)
                Console.WriteLine("No movie aviable");
            else
            {
                Console.WriteLine("Avilable movies are:"+ countAvialableMovies);
                for(int i=0;i<movies.Length;i++)
                {
                    Console.WriteLine("Name of the movie"+":"+movies[i].Name);
                    Console.WriteLine("Year of the movie"+":"+movies[i].Year);
                }
            }

        }

        public void Exit()
        {
            bool exitScreen = true;
            string res = "";
            while(exitScreen)
            {
                Console.WriteLine("Enter Y for continue and N for exit");
                res= Console.ReadLine();
                if(res=="Y")
                    exitScreen = true;
                else
                    exitScreen = false;


            }
        }

        public int AviableMovie
        {
            get
            {
                return movies.Length;
            }
        }
        
        

    }
}
