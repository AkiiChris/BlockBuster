using System;
using System.Collections.Generic;

namespace BlockBuster
{
    abstract class Movie
    {
        public string Title { get; set; }

        public Genre Category { get; set; }

        public int RunTime { get; set; }

        public List<string> Scenes { get; set; } = new List<string>();


        public Movie()
        {

        }

        public Movie(string title, Genre category, int runTime, List<string> scenes)
        {
            Title = title;
            Category = category;
            RunTime = runTime;
            Scenes = scenes;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Runtime: {RunTime}");
        }

        public void PrintScences()
        {
            int counter = 1;

            foreach (string scene in Scenes)
            {
                Console.WriteLine($"Scene {counter}; {scene}");
                counter++;
            }
        }
        public abstract void Play();
    }
}
