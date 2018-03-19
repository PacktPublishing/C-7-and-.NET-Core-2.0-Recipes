using System;
using System.Collections.Generic;
using System.Text;

namespace Example3._5._2
{
    public class FastRunner : IRun
    {
        public void Run(int distance)
        {
            Console.WriteLine("I run fast for {0} kms", distance);
        }
    }
}
