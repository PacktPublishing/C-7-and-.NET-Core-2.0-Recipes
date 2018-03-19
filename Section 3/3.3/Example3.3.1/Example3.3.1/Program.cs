using System;

namespace Example3._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "John";
            person.LastName = "Smith";
            person.Age = 44;
            Console.WriteLine("{0} {1} - age: {2}", person.FirstName, person.LastName, person.Age);
            Console.ReadKey();
        }
    }
} 