using System;

namespace Example3._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            printNum(1);
            printNum(1, 2);
            printNum(1, 2, 3);
            Console.ReadKey();
        }

        static void printNum(int a)
        {
            Console.WriteLine(a);
        }

        static void printNum(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }

        static void printNum(int a, int b, int c)
        {
            int result = a * b * c;
            Console.WriteLine(result);
        }
    }
}