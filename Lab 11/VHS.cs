using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }

        public VHS(string Title, string Category, int RunTime, List<string> Scenes)
            : base(Title, Category, RunTime, Scenes)
        {
            CurrentTime = 0;


        }

        public override void Play()
        {
            //plays the scene at the current time and then increments CurrentTime.
            if (CurrentTime < Scenes.Count)
            {
                string scene = Scenes[CurrentTime];
                Console.WriteLine(scene);
                CurrentTime++;
            }
            else
            {
                Rewind();
            }
        }

        public void Rewind()
        {
            //returns nothing and sets CurrentTime to 0.
            Console.WriteLine("Movie done, rewinding...");
            Console.WriteLine();
            CurrentTime = 0;
        }


    }
}
