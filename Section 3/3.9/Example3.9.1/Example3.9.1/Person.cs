using System;
using System.Collections.Generic;
using System.Text;

namespace Example3._9._1
{
    public class Person
    {
        private string _firstName;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
        }

        private string _lastName;
        public string LastName

        {
            get
            {
                return _lastName;
            }
        }

        public int Age { get; set; }

        public Person(string firstName , string lastName, int age)
        {
            _firstName = firstName;
            _lastName = lastName;
            Age = age;
        }
    }
}
