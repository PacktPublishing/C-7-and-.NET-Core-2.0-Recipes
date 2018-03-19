using System;

namespace Example3._7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinates c = new Coordinates();
            c.Longitude = 45.67890;
            c.Latitude = 38.79851;
            Console.WriteLine("I am here: ( {0} , {1} )", c.Longitude, c.Latitude);
            Console.ReadKey();
        }
    }
}