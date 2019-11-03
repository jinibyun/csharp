using System;
using System.Collections.Generic;
using System.Text;

namespace newVersionCSharp
{
    public class TestMain
    {
        public virtual void Test()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(this.GetType().Name);
            Console.ResetColor();
        }
    }
}
