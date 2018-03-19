using System;

namespace Example3._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John", "Smith", 44);
            person.Age = 17;
            Console.WriteLine("{0} {1} - age: {2}", person.FirstName, person.LastName, person.Age);
            if (person.Age < Person.MinAge)
            {
                Console.WriteLine("Too young");
            }
            Console.ReadKey();
        }
    }
}