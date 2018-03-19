using System;

namespace Example3._8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<string> names = new MyStack<string>();
            names.Push("Jack");
            names.Push("Bob");
            names.Push("Mary");

            while(!names.IsEmpty())
            {
                string name = names.Pop();
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }
    }
}