using System;
using System.Collections.Generic;
using System.Text;

namespace Example3._5._2
{
    public class Person
    {
        private readonly string _firstName;
        private readonly string _lastName;
        private IRun _runner;

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

        public Person(string firstName, string lastName, int age, IRun runner)
        {
            _firstName = firstName;
            _lastName = lastName;
            Age = age;
            _runner = runner;
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
            _runner.Run(distance);
        }
    }
}
