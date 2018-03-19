using System;

namespace Example3._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            myMethod();
            printNumber(6);
            int num = 64;
            printNumber(num);
            Console.ReadKey();
        }

        static void myMethod()
        {
            Console.WriteLine("This is my shiny new method!!");
        }

        static void printNumber(int num)
        {
            Console.WriteLine("Number: {0}", num);
        }
    }
}