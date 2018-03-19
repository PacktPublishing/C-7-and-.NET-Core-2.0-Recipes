using System;
using System.Collections.Generic;
using System.Text;

namespace Example3._5._2
{
    public class Dog
    {
        public string Name { get; set; }
        private IRun _runner;

        public Dog(string name, IRun runner)
        {
            Name = name;
            _runner = runner;
        }

        public void Run(int distance)
        {
            _runner.Run(distance);
        }
    }
}
