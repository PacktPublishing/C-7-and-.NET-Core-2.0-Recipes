using System;
using System.IO;

namespace Example3._11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            writeFile();
            Console.ReadKey();
        }

        private static void writeFile()
        {
            StreamWriter writer = new StreamWriter("test-file.txt", true);
            writer.WriteLine("Visual Studio is the best IDE");
            writer.Close();
            Console.WriteLine("Wrote to file");
        }
    }
}
