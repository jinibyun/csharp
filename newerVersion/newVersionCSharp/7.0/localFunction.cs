using System;
using System.Collections.Generic;
using System.Text;

namespace newVersionCSharp._7._0
{
    public class localFunction : TestMain
    {
        public override void Test()
        {
            base.Test();

            // 1
            Console.WriteLine(MyCalc(2, 4, 1));

            // 2
            foreach (var item in GetNumbers(100, n => n % 2 == 0))
            {
                Console.WriteLine(item);
            }

        }

        private int MyCalc(int a, int b, int c)
        {
            Console.WriteLine("> " + System.Reflection.MethodBase.GetCurrentMethod().Name);

            int factor = 10;
            int ab = MyFormula(a, b);
            int ac = MyFormula(a, c);
            return Math.Max(ab, ac);

            // local function
            int MyFormula(int x, int y)
            {
                int res = 2 * x + 7 * y - 5;
                return res % factor; // can use factor (this is called closure)
            }
        }


        private IEnumerable<int> GetNumbers(int count, Func<int, bool> filter)
        {
            Console.WriteLine("> " + System.Reflection.MethodBase.GetCurrentMethod().Name);

            if (count < 1) throw new ArgumentException();
            if (filter == null) throw new ArgumentException();

            return NumberIterator();

            // local function
            IEnumerable<int> NumberIterator()
            {
                for (int i = 0; i < count; i++)
                {
                    if (filter(i)) 
                    {
                        yield return i;
                    }
                }
            }
        }
    }
}
