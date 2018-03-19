using System;
using System.Collections.Generic;
using System.Text;

namespace Example3._3._3
{
    public class Person
    {
        public static int MinAge = 18;
        public static int MaxAge = 70;

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


        private decimal _salary;


        public Person(string firstName, string lastName, int age, decimal salary = 45000)
        {
            _firstName = firstName;
            _lastName = lastName;
            Age = age;

            //default value
            _salary = salary;
        }
    }
}
