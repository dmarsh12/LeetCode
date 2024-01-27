using System;
namespace LeetCode.Easy
{
	public static class MergeSortedArray
	{
		public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var index1 = m - 1;
            var index2 = n - 1;
            var mergedIndex = m + n - 1;

            // fill nums1 in reverse order
            while (index1 >= 0 && index2 >= 0)
            {
                if (nums1[index1] > nums2[index2])
                {
                    nums1[mergedIndex] = nums1[index1];
                    index1--;
                }
                else
                {
                    nums1[mergedIndex] = nums2[index2];
                    index2--;
                }

                mergedIndex--;
            }

            while (index2 >= 0)
            {
                nums1[mergedIndex] = nums2[index2];
                index2--;
                mergedIndex--;
            }
        }
    }
}

