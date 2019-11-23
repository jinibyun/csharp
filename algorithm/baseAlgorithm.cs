using System;
using System.Collections.Generic;
using System.Text;

namespace algorithm
{
    public class baseAlgorithm
    {
        public virtual void Test()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(this.GetType().Name);
            Console.ResetColor();
        }
    }
}
