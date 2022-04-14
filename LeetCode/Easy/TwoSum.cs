using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    //Given an array of integers nums and an integer target, return indices
    //of the two numbers such that they add up to target.
    //You may assume that each input would have exactly
    //one solution, and you may not use the same element twice.

    //You can return the answer in any order.
    //Example 1:
    //Input: nums = [2,7,11,15], target = 9
    //Output: [0,1]
    //Explanation: Because nums[0] + nums[1] == 9, we return [0, 1]

    public class TwoSum
    {
        public int[] NumberArray { get; set; } = new int[] { 2, 7, 11, 15};

        public int[] GetIndicesThatAddToTarget(int target = 9)
        {
            var result = new int[2];

            for (int i = 0; i < NumberArray.Length; i++)
            {
                //if (NumberArray[i] > target)
                //    continue;

                for (int j = i + 1; j < NumberArray.Length; j++)
                {
                    Console.WriteLine($"{NumberArray[i]} {NumberArray[j]}");
                    if (NumberArray[i] +  NumberArray[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;  
                        return result;
                    }
                }
            }

            return result;
        }

        public int[] GetIndicesThatAddToTargetWithDictionary(int target, int[] nums)
        {
            var result = new int[2];

            var hashMap = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
                hashMap[nums[i]] = i;

            for (int i = 0; i < nums.Length; i++)
            {
                var valueThatAddsToTarget = target - nums[i];
                if (hashMap[valueThatAddsToTarget] != -1 && hashMap[valueThatAddsToTarget] != i)
                {
                    result[0] = i;
                    result[1] = hashMap[valueThatAddsToTarget];
                    return result;
                }
            }

            return result;
        }

    }
}
