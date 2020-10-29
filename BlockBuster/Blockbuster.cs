using System;
using System.Collections.Generic;

namespace BlockBuster
{
    public class Blockbuster
    {
        public List<Movie> Movies { get; set; }

        public Blockbuster()
        {
            Movies = new List<Movie>
            {
                new DVD("Big Lebowski", Genre.Comedy, 98, new List<string> {"Beat up.", "Nobody messes with the Jesus.", "Cowboy.", "Wife things happen." }),
                new DVD("Halloween", Genre.Horror, 90, new List<string> {"Michael kills mom and dad", "Goes to mental hospital.", "The great escape.", "Walks around town murdering teens in search for his sister." }),
                new DVD("Jurassic Park", Genre.Action, 135, new List<string> {"Jurassic Park is frightening in the dark.", "All the dinosaurs are running wild.", "Someone let T-Rex out of his pen.", "They sure don't act like Barney." }),
                new VHS("Cool Runnings", Genre.Comedy, 90, new List<string> {"Fail to qualify for Olympics", "Recruit Bobsled Legend", "Train in bobsleding", "Crash and Sanka pees himself" }),
                new VHS("The Shining", Genre.Horror, 101, new List<string> {"Books hotel room", "Stay in hotel", "Things happen at the bar", "Goes crazy murderous intentions" }),
                new VHS("The Matrix", Genre.Action, 122, new List<string> {"Escapes from white rabbit", "Morpheus enters", "Kung Fu", "Mr. Smith Helicopter" })
            };
        }

        public void PrintMovies()
        {
            for (int i = 0; i < Movies.Count; i++)
            {
                Console.WriteLine($"  {i + 1}){Movies[i].Title}");
            }
        }
        public Movie Checkout()
        {
            PrintMovies();

            Console.Write("Select movie: ")
            string userResponse = Console.ReadLine();

            int movie = int.Parse(userResponse);

            movie = movieIndex - 1;

            Movies[movieIndex].PrintInfo();

            return Movies[movieIndex];
        }
    }
}
