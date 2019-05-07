using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Blockbuster
    {
        List<Movie> Movies { get; set; }

        public Blockbuster()
        {
            Movies = new List<Movie>();
            List<string> DumbScenes = new List<string>() { "swindle blind kid", "kill gas man" };
            VHS dumbDumber = new VHS("Dumb and Dumbber", "Comedy", 120, DumbScenes);
            Movies.Add(dumbDumber);

        }


        public void PrintMovies()
        {
            for(int i =0; i < Movies.Count; i++)
            {
                Movie m = Movies[i];
                Console.WriteLine($"{i}:{m.Title}");
            }
            
        }

        public void Checkout()
        {
            //Print movies
            PrintMovies();
            //Prompt user to select a movie
            Console.WriteLine("Please select a movie you'd like to watch");
            //Get user input
            string input = Console.ReadLine();
            int index = int.Parse(input);
            //Use inputed index to grab a movie from the list
            Movie m = Movies[index];
            
            m.Play();


        }
    }
}
