using System;
using System.Collections.Generic;
using System.Text;

namespace algorithm.Recursion
{
    // ref: https://www.w3resource.com/csharp-exercises/recursion/csharp-recursion-exercise-1.php
    public class _01_Print_the_first_n_natural_number:baseAlgorithm
    {
        public override void Test()
        {
            base.Test();
            doTest(1, 10);
        }

        private int doTest(int stval, int ctr)
        {
            if (ctr < 1) return stval;

            ctr--;
            Console.Write(" {0} ", stval);
            return doTest(stval + 1, ctr);

        }
    }
}
