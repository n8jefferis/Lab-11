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
            this.CurrentTime = CurrentTime;
            

        }

        public override void Play()
        {
            //plays the scene at the current time and then increments CurrentTime.
            int i;
            for (i = 0; i < RunTime; i++)
            {
                CurrentTime = i;


                string scene = Scenes[0];
                Console.WriteLine(scene);
            }
        }

        public void Rewind()
        {
            //returns nothing and sets CurrentTime to 0.
            CurrentTime = 0;
        }


    }
}
