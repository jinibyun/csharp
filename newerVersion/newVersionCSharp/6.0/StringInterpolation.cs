using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace newVersionCSharp._6._0
{
    public class StringInterpolation: TestMain
    {
        public override void Test()
        {
            Rectangle r = new Rectangle();
            r.Height = 10;
            r.Width = 32;

            string s = $"{r.Height} x {r.Width} = {(r.Height * r.Width)}";
            Console.WriteLine(s);
        }
    }
}
