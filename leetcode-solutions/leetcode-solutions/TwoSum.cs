using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_solutions
{
    internal class TwoSum
    {
        public int[] Solution(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            int index;

            for (int j = 0; j < nums.Length; j++)
            {
                var val = target - nums[j];
                if (val > 0 && dict.TryGetValue(val, out index))
                {
                    return new int[] { index, j };
                }

                if (dict.ContainsKey(nums[j]))
                {
                    dict.Add(nums[j], j);
                }
            }

            return new int[0];
        }

        public int[] SolutiomVersion1(int[] nums, int target)
        {
            var list = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var rightIndex = nums.Length - 1;

                while (rightIndex > i)
                {
                    if (nums[i] + nums[rightIndex] == target)
                    {
                        list.Add(i);
                        list.Add(rightIndex);
                    }

                    rightIndex--;
                }
            }

            return list.ToArray();
        }
    }
}
