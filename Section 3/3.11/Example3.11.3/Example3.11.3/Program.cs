using System;
using System.IO;

namespace Example3._11._3
{
    class Program
    {
        static void Main(string[] args)
        {
            readFile();
            Console.ReadKey();
        }

        private static void readFile()
        {
            using (StreamReader reader = new StreamReader("test-file.txt"))
            {
                string contents = reader.ReadToEnd();
                Console.WriteLine("File contents:");
                Console.WriteLine(contents);
            }
        }
    }
}
