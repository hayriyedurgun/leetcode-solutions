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
            //var matrixZeroes = new SetMatrixZeros();
            //var arr = new int[][] {
            //    new int[]{-4,-2147483648,6,-7,0},
            //    new int[]{-8,6,-8,-6,0},
            //    new int[]{ 2147483647, 2, -9, -6, -10 }
            //};
            //matrixZeroes.SetZeroes(arr);

            //var sum = new TwoSum();
            //var result = sum.Solution(new int[] { 2, 7, 11, 15 }, 9);
            //result = sum.Solution(new int[] { 3, 2, 4 }, 6);
            //result = sum.Solution(new int[] { 3, 3 }, 6);

            var roman = new RomanToInteger();
            var result = roman.Solution("MCDLXXVI");
        }
    }
}