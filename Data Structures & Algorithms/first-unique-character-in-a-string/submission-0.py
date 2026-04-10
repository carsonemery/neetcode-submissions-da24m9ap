class Solution:
    def firstUniqChar(self, s: str) -> int:
        # Count frequency of each character
        char_count = {}
        
        for char in s:
            char_count[char] = char_count.get(char, 0) + 1
        
        # Find the first character with count 1
        for i, char in enumerate(s):
            if char_count[char] == 1:
                return i
        
        return -1

    


