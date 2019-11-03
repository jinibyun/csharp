using System;
using System.Collections.Generic;
using System.Text;

namespace newVersionCSharp._7._0
{
    public class tupleTest : TestMain
    {
        public override void Test()
        {
            base.Test();
            var list = new List<int> { 1, 2, 3, 4, 5 };

            var r = Calculate(list);  // tuple result

            // both ways are possible
            Console.WriteLine($"{r.count}, {r.sum}, {r.average}");
            Console.WriteLine($"{r.Item1}, {r.Item2}, {r.Item3}");

            // Tuple Deconstruction
            (int cnt, int sum, double avg) = Calculate(list);
            Console.WriteLine($"{cnt}, {sum}, {avg}");
            (cnt, sum, avg) = Calculate(list);
            Console.WriteLine($"{cnt}, {sum}, {avg}");

            // also possible
            //(var cnt, var sum, var avg) = Calculate(list);
            //var (cnt, sum, avg) = Calculate(list);
        }

        // tuple literal return type
        (int count, int sum, double average) Calculate(List<int> data)
        {
            Console.WriteLine("> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            int cnt = 0, sum = 0;
            double avg = 0;

            foreach (var i in data)
            {
                cnt++;
                sum += i;
            }

            avg = sum / cnt;

            return (cnt, sum, avg); // tuple literal
        }
    }
}
