public class Solution {
    public bool IsPalindrome(string s) {
        
        List<char> list  = new();

        foreach (char c in s) {
            if (AlphaNum(c)) {
                list.Add(char.ToLower(c));
            }
        }        

        int i = 0;
        int j = list.Count - 1;

        while (i < j)
        {
            if (list[i] == list[j]) 
            {
                i++;
                j--;
            }
            else 
            {
                return false;
            }
        }

        return true;
    }

    public bool AlphaNum(char c) {
        return (c >= 'A' && c <= 'Z' ||
            c >= 'a' && c <= 'z' ||
            c >= '0' && c <= '9');
    }

}
