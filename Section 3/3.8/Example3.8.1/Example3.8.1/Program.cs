using System;
using System.Collections.Generic;

namespace Example3._8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> games = new List<string>();
            games.Add("Mass Effect");
            games.Add("Bioshock");
            games.Add("Prey");

            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            List<int> randomNumbers = new List<int>();

            Random r = new Random();
            randomNumbers.Add(r.Next(1, 10));
            randomNumbers.Add(r.Next(1, 10));
            randomNumbers.Add(r.Next(1, 10));

            foreach (int n in randomNumbers)
            {
                Console.Write("{0} ", n);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}