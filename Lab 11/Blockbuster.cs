using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Blockbuster
    {
        List<Movie> Movies = new List<Movie>() {m,;

        public void PrintMovies()
        {
            Console.WriteLine(Movies);
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
            string Movie = Movies[index];
            Console.WriteLine(scene);
            PrintInfo();
            //Play movie
            Play();


        }
    }
}
