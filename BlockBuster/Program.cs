using System;

namespace BlockBuster
{
    class Program
    {
        static void Main(string[] args)
        {
            Blockbuster bb = new Blockbuster();

            while (true)
            {
                Console.WriteLine("Welcome to Akii's Blockbuster");
                Console.WriteLine("Please select  Movie from the list:"):

                Movie userMovie = bb.Checkout();

                Console.WriteLine("Do you want to watch the movie? Y/N");
                string userInput = Console.ReadLine();

                if(userInput == "Y")
                {
                    if (userMovie is DVD)
                    {
                        DVD dvd = (DVD)userMovie;
                        Console.WriteLine($"Which scene of the DVD {dvd.Title} would you like to watch? Select 0 to {dvd.scenes.Count}");
                        dvd.Play();
                    }
                    else if (userMovie is VHS)
                    {
                        VHS vhs = (VHS)userMovie;
                    }
                }
            }
        }

    }
}
