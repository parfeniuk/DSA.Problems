namespace DSA.Sandbox
{
    public static class LongestCommonPrefixSolver
    {
        // Write a function to find the longest common prefix string amongst an array of strings.
        // If there is no common prefix, return an empty string "".
        // Example 1:
        // Input: strs = ["flower","flow","flight"]
        // Output: "fl"
        // Example 2:
        // Input: strs = ["dog","racecar","car"]
        // Output: ""
        // Explanation: There is no common prefix among the input strings.
        // Constraints:
        // 0 <= strs.length <= 200
        // 0 <= strs[i].length <= 200
        // strs[i] consists of only lower-case English letters.
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return "";
            }

            var prefix = strs[0];

            // Iterate through the strings and keep removing the last character from the prefix until it is a prefix of the current string
            for (var i = 1; i < strs.Length; i++)
            {
                // Keep removing the last character from the prefix until it is a prefix of the current string
                while (!strs[i].StartsWith(prefix))
                {
                    prefix = prefix[..^1];
                    
                    // No common prefix if at any point the prefix becomes empty
                    if (prefix.Length == 0)
                    {
                        return "";
                    }
                }
            }

            return prefix;
        }
    }
}
