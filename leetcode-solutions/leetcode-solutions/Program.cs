using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace leetcode_solutions
{
    class Program
    {
        static void Main()
        {
            var threeSum = new ThreeSum();
            var result = threeSum.Solution(new int[] { -1, 0, 1, 2, -1, -4 });
            result = threeSum.Solution(new int[] { 0, 1, 1 });
            result = threeSum.Solution(new int[] { 0, 0, 0 });
        }
    }
}