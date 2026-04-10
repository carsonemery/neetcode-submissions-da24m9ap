class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        tracker = set()    

        for i in range(0, len(nums)):
            if nums[i] in tracker:
                return True
            else:
                tracker.add(nums[i])

        return False