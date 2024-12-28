namespace LeetCode.Medium;

public static class ProductOfArray
{
    /// <summary>
    /// Given an integer array nums, return an array answer such that answer[i] is
    /// equal to the product of all the elements of nums except nums[i].
    /// Input: nums = [2,1,3,4]
    /// Output: [12,24,8,6]
    /// </summary>
    /// <returns></returns>
    public static int[] Execute(int[] nums)
    {
        int[] answer = new int[nums.Length];
        
        int leftProduct = 1;
        for (int i = 0; i < nums.Length; i++) {
            answer[i] = leftProduct;
            leftProduct *= nums[i];
        }
        
        // Compute right products and multiply with left products
        int rightProduct = 1;
        for (int i = nums.Length - 1; i >= 0; i--) {
            answer[i] *= rightProduct;
            rightProduct *= nums[i];
        }
        
        return answer;
    }
}