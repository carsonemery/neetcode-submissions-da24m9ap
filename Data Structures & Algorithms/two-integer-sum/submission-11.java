class Solution {
    public int[] twoSum(int[] nums, int target) {
        int[] result = new int[2];
        Map<Integer, Integer> map = new HashMap();

        // key integer, value index

        for (int i = 0; i < nums.length; i ++) {
            int difference = target - nums[i];
            if (map.containsKey(difference)) {
                result[0] = map.get(difference);
                result[1] = i;
            }

            map.put(nums[i], i);

        }

        return result;

    }
}
