using System;
using System.Collections.Generic;
using System.Text;

namespace algorithm.Recursion
{
    // ref: https://www.w3resource.com/csharp-exercises/recursion/csharp-recursion-exercise-4.php
    public class _04_individual_digit_of_given_number: baseAlgorithm
    {
        public override void Test()
        {
            base.Test();
            int num = 35;
            doTest(num);
        }

        private void doTest(int num)
        {
            if (num > 10)
            {
                var remainder = num % 10;
                Console.WriteLine(string.Format("Each Number: {0}", remainder));
                var va = num / 10;
                doTest(va);
            }
            else
            {
                Console.WriteLine(string.Format("Each Number: {0}", num));
            }
        }
    }
}
