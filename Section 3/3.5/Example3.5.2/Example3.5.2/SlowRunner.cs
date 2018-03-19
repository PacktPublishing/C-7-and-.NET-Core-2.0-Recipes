using System;
using System.Collections.Generic;
using System.Text;

namespace Example3._5._2
{
    public class SlowRunner : IRun
    {
        public void Run(int distance)
        {
            Console.WriteLine("I run slowly for {0} kms", distance);
        }
    }
}
