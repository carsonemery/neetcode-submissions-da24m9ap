class Solution:
    def findKthLargest(self, nums: List[int], k: int) -> int:
        
        min_heap = []
        
        for item in nums:

            heapq.heappush(min_heap, item)

            if len(min_heap) > k:
                heapq.heappop(min_heap)
        

        return heapq.heappop(min_heap)

            
            