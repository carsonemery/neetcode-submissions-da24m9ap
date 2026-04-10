public class Solution {
    public void SortColors(int[] nums) {
        
        int[] buckets = new int[3];

        // Iterate through the input nums with an indexer i
        // for each element in nums, get its color/(value)
        // then track the number of times we have seen that 
        // color based on its value which can represent an index in buckets
        for (int i = 0; i < nums.Length; i++)
        {
            int color = nums[i];
            buckets[color]++;
        }

        // Iterate through buckets and for each element iterate through its number of times
        // overriding the nums array
        int indexBackToNums = 0;
        for (int i = 0; i < buckets.Length; i++)
        {
            int n = buckets[i];
            for (int j = 0; j < n; j++)
            {
                nums[indexBackToNums] = i;
                indexBackToNums++;
            }

        }

    }
}