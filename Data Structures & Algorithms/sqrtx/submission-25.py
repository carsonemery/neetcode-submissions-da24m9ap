class Solution:
    def mySqrt(self, x: int) -> int:
        if x < 2: 
            return x

        left = 0
        right = x // 2
        result = 0

        while left <= right:
            mid = left + (right - left) // 2
            sq = mid * mid

            if sq > x:
                right = mid - 1
            elif sq < x:
                left = mid + 1
                result = mid
            else:
                return mid

        return result 