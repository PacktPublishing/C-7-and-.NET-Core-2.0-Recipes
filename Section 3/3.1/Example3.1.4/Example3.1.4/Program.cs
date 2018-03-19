using System;
using System.Text;

namespace Example3._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();
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
                    builder.Append(input + " ");
                }
            }
            Console.WriteLine("Result: {0}", builder.ToString());
            Console.ReadKey();
        }
    }
}