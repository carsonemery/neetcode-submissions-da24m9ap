class Solution:
    def containsNearbyDuplicate(self, nums: List[int], k: int) -> bool:
        dictionary = {}
        # key = nums[i], value = i
        
        for i in range(0, len(nums)):
            if nums[i] in dictionary and i - dictionary[nums[i]] <= k:
                return True
                # if its in the dictionary we need to minimize the abs() calc
                # index = dictionary[nums[i]]
                # if abs(index - i) <= k:
                # #     return True
                # # else:
                #     return False
            else:
                dictionary[nums[i]] = i

        return False

        # 0,2,3
        # k = 1
        # abs(0-2) = 2 <= 1 FALSE
        # abs(2-3) = 1 <= 1 TRUE



