using System;
using System.Collections.Generic;

namespace Example3._9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = new Person("John", "Smith", 32);
            doSomething(obj);

            List<int> list = new List<int>();
            doSomething(list);

            Console.ReadKey();
        }

        private static void doSomething(object o)
        {
            Person p = o as Person;
            if(p == null)
            {
                throw new ArgumentException("Argument is not a person");
            }
            Console.WriteLine(p.FirstName + " " + p.LastName);
        }
    }
}