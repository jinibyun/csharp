using System;
using System.Collections.Generic;
using System.Text;

namespace algorithm.Recursion
{
    // ref: https://www.w3resource.com/csharp-exercises/recursion/csharp-recursion-exercise-2.php
    public class _02_Print_numbers_from_n_to_1 : baseAlgorithm
    {
        public override void Test()
        {
            base.Test();

            doTest(20);
        }

        private void doTest(int n)
        {
            if (n < 1) return;

            Console.Write("{0}, ", n);
            doTest(n - 1);
        }
    }
}
