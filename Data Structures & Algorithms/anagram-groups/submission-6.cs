public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        // dictionary of array(key), frequency or actual string value?
        Dictionary<string, List<string>> dictionary = new ();

        foreach (string word in strs) {

            int[] charCounts = new int[26];

            foreach (char character in word) {

                charCounts[character - 'a']++; 

            }

            string wordKey = string.Join(",", charCounts);

            if (!dictionary.ContainsKey(wordKey)) {
                dictionary[wordKey] = new List<string>();
            } 
            dictionary[wordKey].Add(word);
        }
        
        return dictionary.Values.ToList<List<string>>();
    }
}
