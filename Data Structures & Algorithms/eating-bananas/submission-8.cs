public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int minK = 1;
        int maxK = piles.Max();
        int result = maxK;

        while (minK <= maxK)
        {
            int mid = minK + (maxK - minK) / 2;

            if (CanFinish(piles, h, mid))
            {
                result = mid;   // mid works, but try smaller
                maxK = mid - 1;
            }
            else
            {
                minK = mid + 1; // mid too slow, need faster
            }
        }
        return result;
    }

    private bool CanFinish(int[] piles, int h, int k)
    {
        int totalTime = 0;
        foreach (int pile in piles)
            totalTime += (int)Math.Ceiling((double)pile / k);
        return totalTime <= h;
    }
}

