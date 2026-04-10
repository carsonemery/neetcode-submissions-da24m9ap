
public class Solution 
{
    public int MySqrt(int x) 
    {
        if (x < 2) return x; // Handle 0 and 1 directly
        
        int left = 1;
        int right = x / 2; // Optimize upper bound
        int result = 0;

        while (left <= right) 
        {
            int mid = left + (right - left) / 2;
            // Cast mid to long BEFORE multiplication to avoid overflow
            long squared = (long)mid * mid;

            if (squared > x)
            {
                right = mid - 1;
            } 
            else if (squared < x) 
            {
                left = mid + 1; 
                result = mid;
            } 
            else 
            {
                return mid;
            }
        }

        return result;
    }
}