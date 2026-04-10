// Definition for a pair.
// public class Pair {
//     public int Key;
//     public string Value;
//
//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
// }
public class Solution {
    public List<Pair> MergeSort(List<Pair> pairs) {
        return MergeSortHelper(pairs, 0, pairs.Count - 1);
    }


    public List<Pair> MergeSortHelper(List<Pair> pairs, int s, int e) {
        if (e - s + 1 <= 1) {
            return pairs;
        }
        
        // Find the middle index
        int m = s + (e - s) / 2; // safest way to calculate a mid point

        // sort the left half
        MergeSortHelper(pairs, s, m);

        // sort the right half 
        MergeSortHelper(pairs, m + 1, e);

        // merge sorted halves
        Merge(pairs, s, m, e);

        return pairs;

    }

    public void Merge(List<Pair> arr, int s, int m, int e) {
        // copy sorted left and right halves into temp arrays
        List<Pair> L = new List<Pair>(arr.GetRange(s, m - s + 1));
        List<Pair> R = new List<Pair>(arr.GetRange(m + 1, e - m));

        // get an index for L
        int i = 0;

        // get an index for R 
        int j = 0;

        // get an index for arr
        int k = s;

        // merge the two sorted halves into the original array using a while loop
        // 
        while (i < L.Count && j < R.Count) {
            if (L[i].Key <= R[j].Key) {
                arr[k] = L[i];
                i++;
            } else{
                arr[k] = R[j];
                j++;
            }
            k++;
        }

        // one of the halves will have elements remaining
        while (i < L.Count) {
            arr[k] = L[i];
            i++;
            k++;
        }
        while (j < R.Count) {
            arr[k] = R[j];
            j++;
            k++;
        }


    }

}
