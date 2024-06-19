namespace DSA.Sandbox.String.Easy
{
    // Leetcode 387. First Unique Character in a String
    // Link to the problem - https://leetcode.com/problems/first-unique-character-in-a-string/
    public static class FirstUniqCharSolver
    {
        // Given a string s, return the first non-repeating character in it and return its index. If it does not exist, return -1.
        // Example 1:
        // Input: s = "leetcode"
        // Output: 0
        // Example 2:
        // Input: s = "loveleetcode"
        // Output: 2
        // Example 3:
        // Input: s = "aabb"
        // Output: -1
        // Constraints:
        // 1 <= s.length <= 10^5
        // s consists of only lowercase English letters.

        public static int FirstUniqChar(string s)
        {
            // Handle edge cases
            if (s is null || s.Length == 0)
            {
                return -1;
            }

            if (s.Length == 1)
            {
                return 0;
            }

            // Find occurancies of each lower Case English letter in the input string
            var lowerCaseEnglishLettersCount = 26;
            var charCountsFrequency = new int[lowerCaseEnglishLettersCount];

            // We use the ASCII value of the character to determine the index in the array
            for (int i = 0; i < s.Length; i++)
            {
                charCountsFrequency[s[i] - 'a']++;
            }

            // Iterate through array of chars frequency and return the first index with value == 1
            for (int i = 0; i < s.Length; i++)
            {
                if (charCountsFrequency[s[i] - 'a'] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
