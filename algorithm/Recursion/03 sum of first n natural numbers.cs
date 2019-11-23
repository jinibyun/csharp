using System;
using System.Collections.Generic;
using System.Text;

namespace algorithm.Recursion
{
    // ref: https://www.w3resource.com/csharp-exercises/recursion/csharp-recursion-exercise-3.php
    public class _03_sum_of_first_n_natural_numbers: baseAlgorithm
    {
        int sum = 0;
        public override void Test()
        {
            base.Test();

            doTest(10);
        }

        private void doTest(int n)
        {
            if (n > 0)
            {
                sum += n;
                n--;
                doTest(n);
            }
            else
            {
                Console.WriteLine(sum);
            }
        }
    }
}
