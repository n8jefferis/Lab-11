using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Scenes = new List<string>() { "Capture Leia", "Blow up deathstar", "Pizza the Hut" };
            Movie m = new Movie("Space Balls", "Comedy", 120, Scenes);

            m.PrintInfo();
            m.Play();
            Console.WriteLine();

            List<string> Scenes2 = new List<string>() { "Cantina Scene", "Jefferson Starship", "Boba Fet" };
            DVD d = new DVD("Star Wars Holiday Special", "Hot Mess", 80, Scenes2);
            d.Play();

            List<string> Scenes3 = new List<string>() { "Beyond the wall", "Winterfell", "The Godswood", "Kings Landing", "Letter from the Eyrie," };
            VHS v = new VHS("GOT season 1", "Fantasy", 60, Scenes3);
            v.Play(); 
            Blockbuster b = new Blockbuster();


        
        }
    }
}
