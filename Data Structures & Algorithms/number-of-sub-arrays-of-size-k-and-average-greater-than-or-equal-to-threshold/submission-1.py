class Solution:
    def numOfSubarrays(self, arr: List[int], k: int, threshold: int) -> int:
        L = 0
        R = 0
        sumElems = 0
        output = 0
        curSum = 0

        for R in range(0, len(arr)):
            curSum += arr[R]
            sumElems += 1
   
            # if sumElems = k we need to check the avg
            # we found an avg we want to track
            if sumElems == k:
                if curSum >= (threshold * k):
                    # increase the output value
                    output += 1
                    
                # remove the value at the L pointer positon from the curSum
                # for the next iteration 
                curSum -= arr[L]

                # increase our L pointer
                L += 1
                
                # make our sumElems count one smaller
                sumElems -= 1

        
        return output 
        
        
        
        
        
        
        
        
        # count = 0
        # tempSum = 0

        # # for 0 to len of array
        # for i in range(0, len(arr)):
        #     # for i to (i + k) or the end of the array
        #     for j in range(i, min(i+k, len(arr))):
        #         tempSum += arr[j]
        #         avg = (int) (tempSum / k)
        #         # print(avg)
        #     if avg >= threshold:
        #         print("avg")
        #         print(avg)
        #         print("i")
        #         print(i)
        #         print("j")
        #         print(j)
        #         print("k")
        #         print(k)
        #         print("THRESHOLD")
        #         print(threshold)
        #         count += 1
        #     else:
        #         tempSum = 0
        # return count
