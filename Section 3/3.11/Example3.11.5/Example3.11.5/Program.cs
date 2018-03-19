using System;
using System.IO;

namespace Example3._11._5
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
            try
            {
                using (StreamReader reader = new StreamReader("test-file.txt"))
                {
                    string contents = reader.ReadToEnd();
                    Console.WriteLine("File contents:");
                    Console.WriteLine(contents);
                }
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("File not found");
            }
            catch(FileLoadException e)
            {
                Console.WriteLine("File load failed");
            }
            catch(Exception)
            {
                Console.WriteLine("File operation failed");
            }
        }
    }
}
