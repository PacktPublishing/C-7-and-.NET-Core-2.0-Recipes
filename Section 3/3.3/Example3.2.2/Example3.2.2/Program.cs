using System;

namespace Example3._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John", "Smith", 44);
            person.Age = 28;
            Console.WriteLine("{0} {1} - age: {2}", person.FirstName, person.LastName, person.Age);
            Console.ReadKey();
        }
    }
}