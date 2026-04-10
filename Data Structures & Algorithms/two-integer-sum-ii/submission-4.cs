public class Solution 
{
    public int[] TwoSum(int[] numbers, int target) 
    {
        int[] result = new int[2];

        int right = numbers.Length - 1;
        int left = 0;

        while((numbers[left] + numbers[right]) != target)
        {

            if ((numbers[left] + numbers[right]) > target)
            {
                right--;
            }
            else if ((numbers[left] + numbers[right]) < target)
            {
                left++;
            }
        }

        result[0] = (left += 1);
        result[1] = (right += 1);

        return result;
    }
}
