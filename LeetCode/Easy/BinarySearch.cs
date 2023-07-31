using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public static class BinarySearch
    {
        public static void ExampleOne()
        {
            var nums = new int[] { -1, 0, 3, 5, 9, 12 };
            Console.WriteLine(Search(nums, 9));
        }

        public static void ExampleTwo() 
        {
            var nums = new int[] { -1, 0, 3, 5, 9, 12 };
            Console.WriteLine(Search(nums, 2));
        }

        public static void ExampleThree() 
        {
            var nums = new int[] { -1, 0, 5 };
            Console.WriteLine(Search(nums, 0));
        }

        public static int Search(int[] numbers, int value)
        {
            if (numbers[0] == value)
                return 0; 
            
            if (numbers[numbers.Length-1] == value) 
                return numbers.Length-1;

            var start = 0;
            var end = numbers.Length-1;

            while (start <= end)
            {
                var mid = (start + end) / 2;

                var foundValue = numbers[mid];
                if (foundValue == value)
                    return mid;

                if (foundValue < value)
                {
                    start = mid + 1; 
                }
                else
                {
                    end = mid - 1;
                }
            }

            return -1;
        }
    }
}
