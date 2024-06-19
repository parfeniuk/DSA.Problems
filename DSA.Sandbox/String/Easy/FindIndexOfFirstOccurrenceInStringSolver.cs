namespace DSA.Sandbox
{
    // Leetcode 28. Implement strStr()
    // Link to the problem - https://leetcode.com/problems/implement-strstr/
    public static class FindIndexOfFirstOccurrenceInStringSolver
    {
        // Write a function to find the index of the first occurrence of a substring in a string.
        // If the substring is not found, return -1.
        // Example 1:
        // Input: s = "hello", sub = "ll"
        // Output: 2
        // Example 2:
        // Input: s = "aaaaa", sub = "bba"
        // Output: -1
        // Constraints:
        // 1 <= s.length, sub.length <= 10^4
        // s and sub consist of lower-case English letters.
        public static int FindIndexOfFirstOccurrenceInString(string s, string sub) 
        {
            if (s is null || sub is null || (sub.Length > s.Length))
            {
                return -1;
            }

            if (string.Equals(s, sub)) 
            {
                return 0;
            }

            if (sub.Length == 0) 
            {
                return -1;
            }

            for (int i = 0; i < s.Length; i++) 
            {
                if (s[i..^0].StartsWith(sub)) 
                {
                    return i;
                }
            }

            return -1;
        }

    }
}
