using System;

namespace Example3._6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie("Star Wars", 1977, MovieGenre.Scifi);
            printMovieGenre(movie);
            Console.ReadKey();
        }

        private static void printMovieGenre(Movie movie)
        {
            switch (movie.Genre)
            {
                case MovieGenre.Action:
                    Console.WriteLine("Action Movie");
                    break;
                case MovieGenre.Comedy:
                    Console.WriteLine("Comedy Movie");
                    break;
                case MovieGenre.Scifi:
                    Console.WriteLine("Science Fiction Movie");
                    break;
                case MovieGenre.Horror:
                    Console.WriteLine("Horror Movie");
                    break;
                default:
                    Console.WriteLine("Invalid Movie Genre");
                    break;
            }
        }
    }
}