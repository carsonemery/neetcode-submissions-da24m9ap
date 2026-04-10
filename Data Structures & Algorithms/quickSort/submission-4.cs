// public class Pair {
//     public int Key;
//     public string Value; 
//
//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
// }
public class Solution 
{
    public List<Pair> QuickSort(List<Pair> pairs) 
    {
        return QuickSorting(pairs, 0, pairs.Count - 1);
    }

    public List<Pair> QuickSorting(List<Pair> pairs, int lo, int hi)
    {
        if (lo >= hi) return pairs;

        // 1. pick pivot and swap it to the end
        int pivotValue = pairs[hi].Key;

        // 2. partition - left tracks where next "small" element goes
        int left = lo;
        for (int i = lo; i < hi; i++)  // don't include hi (that's the pivot)
        {
            if (pairs[i].Key < pivotValue)
            {
                Swap(pairs, i, left);
                left++;
            }
        }

        // 3. place pivot in its final sorted position
        Swap(pairs, left, hi);

        // 4. recurse on both sides (pivot at 'left' is already sorted, exclude it)
        QuickSorting(pairs, lo, left - 1);
        QuickSorting(pairs, left + 1, hi);

        return pairs;
    }

    private void Swap(List<Pair> pairs, int a, int b)
    {
        Pair temp = pairs[a];
        pairs[a] = pairs[b];
        pairs[b] = temp;
    }

    public int MedianThree(List<Pair> pairs, int lo, int hi)
    {
        int mid = lo + (hi - lo) / 2;
        
        if ((pairs[lo].Key - pairs[hi].Key) * (pairs[lo].Key - pairs[mid].Key) <= 0) return lo;
        if ((pairs[hi].Key - pairs[lo].Key) * (pairs[hi].Key - pairs[mid].Key) <= 0) return hi;
        return mid;
    }
}
