public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;
    
        while (left <= right) {
            int mid = (left + right) / 2;
            
            // if the target is less than the value at the mid point
            // it means we should update the right pointer to be placed at mid
            if (target < nums[mid]) {
                right = mid - 1;
            } 

            else if (target > nums[mid]) {
                left = mid + 1;
            }

            else {
                return mid;
            }
        }
        return -1;

    }
}
