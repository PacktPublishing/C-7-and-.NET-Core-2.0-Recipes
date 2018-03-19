using System;
using System.Text;

namespace Example3._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double myDouble = 4.56;
            Console.WriteLine("myDouble in Main: {0}", myDouble);
            incrementDouble(myDouble);
            Console.WriteLine("myDouble in Main: {0}", myDouble);

            StringBuilder builder = new StringBuilder();
            builder.Append("Hello");
            builder.Append("C#");
            addExclamationMarks(builder);
            Console.WriteLine("String builder in Main: {0}", builder.ToString());

            Console.ReadKey();
        }

        static void incrementDouble(double d)
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