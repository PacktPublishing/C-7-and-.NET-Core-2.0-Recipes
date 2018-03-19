using System;

namespace Example3._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            while (true)
            {
                Console.WriteLine("Type a word: ");
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                else
                {
                    result += input + " ";
                }
            }
            Console.WriteLine("Result: {0}", result);
            Console.ReadKey();
        }
    }
}