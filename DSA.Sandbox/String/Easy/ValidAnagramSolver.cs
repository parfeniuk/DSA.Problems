namespace DSA.Sandbox
{
    // Leetcode 242. Valid Anagram
    public static class ValidAnagramSolver
    {
        // Given two strings s and t, return true if t is an anagram of s, and false otherwise.
        // Example 1:
        // Input: s = "anagram", t = "nagaram"
        // Output: true
        // Example 2:
        // Input: s = "rat", t = "car"
        // Output: false
        // Constraints:
        // 1 <= s.length, t.length <= 5 * 10^4
        // s and t consist of lowercase English letters.
        
        // 
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            // Count the number of occurrences of each character in the two strings
            var sCharCount = new int[26];
            var tCharCount = new int[26];

            // 'a' - 'a' = 0, 'b' - 'a' = 1, 'c' - 'a' = 2, ..., 'z' - 'a' = 25
            // Index value normalized to be in the range [0..25]
            for (int i = 0; i < s.Length; i++)
            {
                sCharCount[s[i] - 'a']++;
                tCharCount[t[i] - 'a']++;
            }
            // Compare the count of each character in the two strings
            for (int i = 0; i < 26; i++)
            {
                if (sCharCount[i] != tCharCount[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
