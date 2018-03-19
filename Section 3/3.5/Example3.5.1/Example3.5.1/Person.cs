using System;
using System.Collections.Generic;
using System.Text;

namespace Example3._5._1
{
    public class Person : IRun
    {
        private readonly string _firstName;
        private readonly string _lastName;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
        }

        public int Age { get; set; }

        public Person(string firstName, string lastName, int age)
        {
            _firstName = firstName;
            _lastName = lastName;
            Age = age;
        }

        public virtual void SayHello()
        {
            Console.WriteLine("Hello I'm a Person");
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " - age: " + Age;
        }

        public void Run(int distance)
        {
            Console.WriteLine("I run for {0} kms", distance);
        }
    }
}
