using System;
using System.Collections.Generic;
using System.Text;

namespace Example3._3._1
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;

        private decimal _salary;
        
        public Person()
        {
            //Empty constructor
        }

        public Person(string firstName, string lastName, int age, decimal salary=45000)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;

            //default value
            _salary = salary;
        }
    }
}
