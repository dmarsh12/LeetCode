using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public static class MajorityElement
    {
        public static int Get(int[] nums)
        {
            Array.Sort(nums);
            return nums[nums.Length / 2]; // because we know that there is always a majority, we can safely just take the middle after the sort.
        }
    }
}
