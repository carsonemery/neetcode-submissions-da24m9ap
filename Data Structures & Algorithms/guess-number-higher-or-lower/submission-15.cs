/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        
        int min = 1;
        int max = n;
        int mid = 0;

        while (min <= max) {
            mid = min + (max - min) / 2;
            int result = guess(mid);

            // my guess is higher, lower my guess
            if (result == -1) {
                max = mid - 1;
            } 
            // my guess is lower, increase my guess
            else if (result == 1) {
                min = mid + 1;
            }
            else {
                return mid;
            }
        }
        return mid;
    }
}