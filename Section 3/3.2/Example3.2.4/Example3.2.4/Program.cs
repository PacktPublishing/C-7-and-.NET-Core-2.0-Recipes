using System;
using System.Text;

namespace Example3._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double myDouble = 4.56;
            Console.WriteLine("myDouble in Main: {0}", myDouble);
            incrementDouble(ref myDouble);
            Console.WriteLine("myDouble in Main: {0}", myDouble);

            Console.ReadKey();
        }

        static void incrementDouble(ref double d)
        {
            d++;
            Console.WriteLine("myDouble in incrementDouble: {0}", d);
        }

        static void addExclamationMarks(StringBuilder b)
        {
            b.Append("!!!!!!!");
        }
    }
}