public class Solution {

    public string Encode(IList<string> strs) {
        
        string result = string.Empty;

        for (int i = 0; i < strs.Count; i++) {
            string element = strs[i];
            result += element.Length;
            result += "#";

            for (int j = 0; j < element.Length; j++) {
                result += (element[j]);
            }
        }

        return result;
    }

    // example:3#sun4#moon5#stars

    public List<string> Decode(string s) {
        
        int position = 0;
        List<string> result = new ();

        while (position < s.Length)
        {
            string lengthStr = string.Empty;

            // Build up the length string
            while (s[position] != '#')
            {
                lengthStr += s[position];
                position++;
            }

            position++; // increment position one more time to get past #

            // Convert to int
            int length = int.Parse(lengthStr);

            string element = string.Empty;

            for (int i = 0; i < length; i++)
            {
                element += s[position];
                position++;
            }

            result.Add(element);

        }

        return result;

   }
}
