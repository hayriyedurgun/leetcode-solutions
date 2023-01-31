using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_solutions
{
    public class ThreeSum
    {
        //Brute force solution
        public IList<IList<int>> Solution(int[] arr)
        {
            var len = arr.Length;
            var pairs = new List<Pair>();

            for (int i = 0; i < len; i++)
            {
                for (int j = i; j < len; j++)
                {
                    for (int k = j; k < len; k++)
                    {
                        if (i == k || i == j || j == k)
                        {
                            continue;
                        }

                        if (arr[i] + arr[j] + arr[k] == 0)
                        {
                            var pair = new Pair(arr[i], arr[j], arr[k]);
                            if (!pairs.Any(x => x.Equals(pair)))
                            {
                                pairs.Add(pair);
                            }
                        }
                    }
                }
            }

            var result = new List<IList<int>>();
            foreach (var pair in pairs)
            {
                result.Add(pair.ToList());
            }

            return result;
        }
    }

    public sealed class Pair : IEquatable<Pair>
    {
        public int Element0 { get; private set; }
        public int Element1 { get; private set; }
        public int Element2 { get; private set; }

        public Pair(int element0, int element1, int element2)
        {
            Element0 = element0;
            Element1 = element1;
            Element2 = element2;
        }

        public List<int> ToList()
        {
            return new List<int> { Element0, Element1, Element2 };
        }

        public bool Equals(Pair? other)
        {
            if (other == null)
            {
                return false;
            }

            if ((other.Element0 == Element0 ||
                 other.Element0 == Element1 ||
                 other.Element0 == Element2) &&
                 (other.Element1 == Element0 ||
                 other.Element1 == Element1 ||
                 other.Element1 == Element2) &&
                 other.Element2 == Element0 ||
                 other.Element2 == Element1 ||
                 other.Element2 == Element2)
            {
                return true;
            }

            return false;
        }
    }
}
