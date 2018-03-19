using System;

namespace Example3._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student("John", "Smith", 21);
            std.University = "Harvard University";
            std.AvgGrade = 8;

            Console.WriteLine(std);

            Console.ReadKey();
        }
    }
}