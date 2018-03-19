using System;

namespace Example3._5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person slow = new Person("John", "Smith", 32, new SlowRunner());
            Person fast = new Person("Ann", "Smith", 27, new FastRunner());
            Dog d = new Dog("Max", new FastRunner());
            slow.Run(5);
            fast.Run(5);
            d.Run(3);
            Console.ReadKey();
        }
    }
}