public class Solution 
{
    public int[] TwoSum(int[] numbers, int target) 
    {
        int[] result = new int[2];

        int right = numbers.Length - 1;
        int left = 0;

        while((numbers[left] + numbers[right]) != target)
        {
            Console.WriteLine($"right: {numbers[right]}");
            Console.WriteLine($"left: {numbers[left]}");
            Console.WriteLine($"sum {numbers[right] + numbers[left]}");

            if ((numbers[left] + numbers[right]) > target)
            {
                right--;
            }
            else if ((numbers[left] + numbers[right]) < target)
            {
                left++;
            }
        }
        Console.WriteLine("out of while loop");
        Console.WriteLine($"right number: {numbers[right]}");
        Console.WriteLine($"left number: {numbers[left]}");
        Console.WriteLine($"right index: {right}");
        Console.WriteLine($"left index: {left}");


        result[0] = (left += 1);
        result[1] = (right += 1);
    
     

        return result;
    }
}
