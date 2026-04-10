// Definition for a pair
// public class Pair {
//     public int Key;
//     public string Value;

//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
// }

public class Solution {
    // Implementation of Insertion Sort
    public List<List<Pair>> InsertionSort(List<Pair> pairs) {
        int n = pairs.Count;
        List<List<Pair>> res = new List<List<Pair>>();  // To store the intermediate states of the array

        for (int i = 0; i < n; i++) {
            int j = i - 1;

            // Move elements that are greater than key one position ahead
            while (j >= 0 && pairs[j].Key > pairs[j + 1].Key) {
                Pair temp = pairs[j];
                pairs[j] = pairs[j + 1];
                pairs[j + 1] = temp;
                j--;
            }

            // Clone and save the entire state of the array at this point
            List<Pair> cloneList = new List<Pair>(pairs);
            res.Add(cloneList);
        }
        return res;
    }
}
