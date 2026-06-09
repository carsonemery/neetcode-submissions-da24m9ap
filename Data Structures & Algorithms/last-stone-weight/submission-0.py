import heapq

class Solution:
    def lastStoneWeight(self, stones: List[int]) -> int:
        # 1. Turn all stones negative to simulate a max-heap
        max_heap = [-s for s in stones]
        heapq.heapify(max_heap)

        # 2. Continue while at least 2 stones exist
        while len(max_heap) > 1:
            first = heapq.heappop(max_heap)  # Heaviest
            second = heapq.heappop(max_heap) # Second heaviest
            
            if first != second:
                # In a min-heap of negative numbers:
                # if first is -6 and second is -4, the new stone is -2
                heapq.heappush(max_heap, first - second)

        # 3. Handle the remaining stone or return 0
        return abs(max_heap[0]) if max_heap else 0