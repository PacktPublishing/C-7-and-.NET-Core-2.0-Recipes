using System;
using System.Collections.Generic;
using System.Text;

namespace Example3._9._1
{
    public class Student : Person
    {
        public string University { get; set; }
        public double Grade { get; set; }

        public Student(string firstName, string lastName, int age, string university, double grade) : base(firstName, lastName, age)
        {
            University = university;
            Grade = grade;
        }
    }
}
