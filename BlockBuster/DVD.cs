using System;
using System.Collections.Generic;

namespace BlockBuster
{
    public class DVD : Movie
    {
        public DVD(string title, Genre categort, int runTime, List<string> scenes): base (title,category,runTime, scences)
        {

        }
        public override void Play()
        {
            Console.Write(" What scene would you like to watch?");

            Console.WriteLine();
            PrintScenes();
            Console.WriteLine();

            string userResoonse = Console.ReadLine();

            int sceneIndes = int.Parse();
        }

        private void PrintScenes()
        {
        }
    }
}
