using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace leetcode_solutions
{
    public class ThreeSum
    {
        //Brute force solution
        public IList<IList<int>> BruteForceSolution(int[] arr)
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

        public IList<IList<int>> Solution(int[] nums)
        {
            var result = new List<IList<int>>();
            var len = nums.Length;
            Array.Sort(nums);

            for (int i = 0; i < len - 2; i++)
            {
                if (i == 0 || i > 0 && nums[i] != nums[i - 1])
                {
                    var left = i + 1;
                    var right = len - 1;

                    while (left < right)
                    {
                        if (nums[i] + nums[left] + nums[right] == 0)
                        {
                            result.Add(new List<int> { nums[i], nums[left], nums[right] });

                            while (left < right &&
                                   nums[left] == nums[left + 1])
                            {
                                left++;
                            }
                            while (left < right &&
                                   nums[right] == nums[right - 1])
                            {
                                right--;
                            }

                            left++;
                            right--;
                        }
                        else if (nums[i] + nums[left] + nums[right] > 0)
                        {
                            right--;
                        }
                        else
                        {
                            left++;
                        }
                    }
                }
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
