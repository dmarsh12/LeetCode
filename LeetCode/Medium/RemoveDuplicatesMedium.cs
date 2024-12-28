using System.ComponentModel;

namespace LeetCode.Medium
{
    public static class RemoveDuplicatesMedium
    {
        // Allow only one duplicate
        public static int Execute(int[] nums)
        {
            int count = 0;
            var lookup = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                if (lookup.ContainsKey(num)) 
                {
                    if (lookup[num] < 2)
                    {
                        count++;
                    }
                    else
                    {
                        for (int j = i; j <= nums.Length-1; j++)
                        {
                            if (j < nums.Length-1)
                                nums[j] = nums[j+1];
                        }                                      
                    }

                    lookup[num]++;
                }
                else
                {
                    lookup[num] = 1;
                }
            }

            return count;
        }        
    }
}
