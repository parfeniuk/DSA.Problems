namespace DSA.Sandbox.String.Easy
{
    // Leetcode 387. First Unique Character in a String
    // Link to the problem - https://leetcode.com/problems/first-unique-character-in-a-string/
    public static class FirstUniqCharUnicodeSolver
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

        // s consists of any UNICODE symbols.
        public static int FirstUniqCharUnicode(string s) 
        {
            if (s is null || s.Length == 0)
            {
                return -1;
            }

            if (s.Length == 1)
            {
                return 0;
            }

            var charCountsFrequency = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (charCountsFrequency.TryGetValue(s[i], out int value))
                {
                    charCountsFrequency[s[i]] = ++value;
                }
                else 
                {
                    charCountsFrequency[s[i]] = 1;
                }
            }

            for (int i = 0; i < s.Length; i++) 
            {
                if (charCountsFrequency[s[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
