using System;
using System.IO;

namespace Example3._11._4
{
    class Program
    {
        static void Main(string[] args)
        {
            readFile();
            Console.ReadKey();
        }

        private async static void readFile()
        {
            using (StreamReader reader = new StreamReader("test-file.txt"))
            {
                string contents = await reader.ReadToEndAsync();
                Console.WriteLine("File contents:");
                Console.WriteLine(contents);
            }
        }
    }
}
