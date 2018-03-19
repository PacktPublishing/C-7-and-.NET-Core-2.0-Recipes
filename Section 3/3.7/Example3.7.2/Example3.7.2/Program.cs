using System;

namespace Example3._7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinates c = new Coordinates();
            c.Longitude = -116.420;
            c.Latitude = 38.8026;
            Console.WriteLine("Coordinates before: ( {0}, {1} )", c.Latitude, c.Longitude);
            changeCoordinates(c);
            Console.WriteLine("Coordinates after: ( {0}, {1} )", c.Latitude, c.Longitude);
            Console.ReadKey();
        }

        private static void changeCoordinates(Coordinates c)
        {
            c.Longitude = 0;
            c.Latitude = 0;
        }
    }
}
