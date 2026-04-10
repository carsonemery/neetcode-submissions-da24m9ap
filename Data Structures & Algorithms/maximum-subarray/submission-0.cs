public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxSum = nums[0];
        int curSum = 0;

        foreach (int i in nums)
        {
            curSum = Math.Max(curSum, 0);
            curSum += i;
            maxSum = Math.Max(curSum, maxSum);
        }

        return maxSum;
    }
}
