using System;

namespace Example3._9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("John", "Smith", 32);
            if(p is Person)
            {
                Console.WriteLine("p is a Person");
            }
            else
            {
                Console.WriteLine("p is not a Person");
            }

            Student s = new Student("Ann", "Smith", 21, "MIT", 9);
            if(s is Student)
            {
                Console.WriteLine("s is a Student");
            }
            else
            {
                Console.WriteLine("s is not a Student");
            }

            if(s is Person)
            {
                Console.WriteLine("s is a Person");
            }
            else
            {
                Console.WriteLine("s is not a Person");
            }

            if(p is Student)
            {
                Console.WriteLine("p is a Student");
            }
            else
            {
                Console.WriteLine("p is not a Student");
            }

            Console.ReadKey();
        }
    }
}