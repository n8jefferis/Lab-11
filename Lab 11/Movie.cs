using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }

        public Movie(string Title, string Category, int RunTime, List<string> Scenes)
        {
            this.Title = Title;
            this.Scenes = Scenes;
            this.RunTime = RunTime;
            this.Category = Category;
        }

        public virtual void PrintScenes()
        {
            //prints all properties in the class to the console.

            for(int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"Scene {i}: {Scenes[i]}");
            }
        }

        public void PrintInfo()
        {
            //prints all the scenes in the list along with their index.
            Console.WriteLine("Movie Info: ");
            Console.WriteLine(Title);
            Console.WriteLine(Category);
            Console.WriteLine(RunTime);
            PrintScenes();
        }

        public virtual void Play()
        {
            Console.WriteLine("The play method only works on physical media");
        } 

        

        

    }
}
