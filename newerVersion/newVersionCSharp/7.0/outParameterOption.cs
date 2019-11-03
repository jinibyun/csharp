using System;
using System.Collections.Generic;
using System.Text;

namespace newVersionCSharp._7._0
{
    public class outParameterOption : TestMain
    {
        public override void Test()
        {
            base.Test();

            // old
            // it should be declared before
            // int x, y;     
            // GetXY(out x, out y);

            // new
            GetXY(out int x, out int y);

            Console.WriteLine($"{x},{y}");

            // out var
            GetXY(out var x2, out var y2);
            Console.WriteLine($"{x2},{y2}");

            // if not need to pass parameter, use _
            GetXY(out var x3, out _);
            Console.WriteLine($"{x3}");
        }

        private void GetXY(out int x, out int y)
        {
            Console.WriteLine("> " + System.Reflection.MethodBase.GetCurrentMethod().Name);

            x = 100;
            y = 99;
        }
    }
}
