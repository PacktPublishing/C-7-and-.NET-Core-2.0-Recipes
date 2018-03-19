using System;

namespace Example3._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("John", "Smith", 32);
            p.Run(5);
            Console.ReadKey();
        }
    }
}