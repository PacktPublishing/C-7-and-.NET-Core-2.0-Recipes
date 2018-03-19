using System;

namespace Example3._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charArray = new char[] { 'a', 'b', 'c' };
            Console.WriteLine("Character array size: {0}", charArray.Length);
            char[] secondArray = new char[4];
            Console.WriteLine("Second character array size: {0}", secondArray.Length);
            secondArray[0] = 'b';
            secondArray[1] = 'a';
            secondArray[2] = 'l';
            secondArray[3] = 'e';

            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.WriteLine(secondArray[i]);
            }

            secondArray[2] = 'z';

            Console.WriteLine("******");

            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.WriteLine(secondArray[i]);
            }

            Console.ReadKey();
        }
    }
}