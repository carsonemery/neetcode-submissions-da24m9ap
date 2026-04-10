public class Solution 
{
    public int[] TopKFrequent(int[] nums, int k) 
    {
        Dictionary<int, int> freqMap = new Dictionary<int, int>();

        // 1) Count frequencies in a dictionary
        foreach (int num in nums)
        {
            freqMap[num] = freqMap.GetValueOrDefault(num, 0) + 1;
        }

        // 2) Create buckets in an array where the index is the freq and the element is an array 
        // with the proper elements
        List<int>[] buckets = new List<int>[nums.Length + 1];

        for (int i = 0; i < buckets.Length; i++)
        {
            buckets[i] = new List<int>();
        }

        foreach (var entry in freqMap){
            buckets[entry.Value].Add(entry.Key);
        }

        int[] result = new int[k];
        int index = 0;
        
        // 3) Get top k from highest frequency buckets
        for (int i = buckets.Length - 1; i >= 0 && index < k; i--)
        {
            foreach (int num in buckets[i])
            {
                result[index++] = num;
                if (index == k) return result;
            }
        }

        return result;
    }
}
