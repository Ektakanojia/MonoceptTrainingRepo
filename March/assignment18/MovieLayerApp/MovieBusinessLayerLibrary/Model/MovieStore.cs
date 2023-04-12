using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBusinessLayerLibrary.Model
{
    public class MovieStore
    {
        //create a array of constructor type
        Movie[] movies = new Movie[5];
        int countAvialableMovies = 0;

       
       public  void AddMovie()
       {
            string name;
            int year;
            Console.WriteLine("Enter the name of the movie");
            name = Console.ReadLine();
            Console.WriteLine("Enter the Year of the movie");
            string movieYear =Console.ReadLine();
            year = int.Parse(movieYear);

            if(countAvialableMovies==movies.Length)
            {
                Array.Resize( ref movies, movies.Length*2);
            }

            movies[countAvialableMovies++]= new Movie { Name =name,Year =year};
           
       }
       public void DisplayMovies()
        {
            if (countAvialableMovies == 0)
                Console.WriteLine("No movie aviable");
            else
            {
                Console.WriteLine("Avilable movies are:"+ countAvialableMovies);
                for(int i=0;i<countAvialableMovies;i++)
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
        public int CountAvilableMovie
        {
            get
            {
                return countAvialableMovies;
            }
        }
    }
}
