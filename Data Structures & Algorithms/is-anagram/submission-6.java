class Solution {
    public boolean isAnagram(String s, String t) {
        Map<Character, Integer> tableS = new HashMap<>();
        Map<Character, Integer> tableT = new HashMap<>();

        if (s.length() != t.length()) return false;

        // key letter, value frequency

        for (int i = 0; i < s.length(); i ++) {
            tableS.put(s.charAt(i), tableS.getOrDefault(s.charAt(i), 0) + 1);
            tableT.put(t.charAt(i), tableT.getOrDefault(t.charAt(i), 0) + 1);
        }

        return tableS.equals(tableT);


    }
}
