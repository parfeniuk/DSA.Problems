namespace DSA.Sandbox
{
    // Leetcode 242. Valid Anagram

    // A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters,
    // it reads the same forward and backward. Alphanumeric characters include letters and numbers.
    
    // Given two strings s and t, return true if t is an anagram of s, and false otherwise.
    // Constraints:
    // 1 <= s.length, t.length <= 5 * 10^4
    // s and t consist of lowercase English letters.
    // Input: s = "anagram", t = "nagaram"
    // Output: true
    // Explanation: t is an anagram of s.
    // Input: s = "rat", t = "car"
    // Output: false
    // Explanation: t is not an anagram of s.
    public class ValidAnagramUnicodeSolver
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            var sCharCount = new Dictionary<char, int>();
            var tCharCount = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (sCharCount.ContainsKey(s[i]))
                {
                    sCharCount[s[i]]++;
                }
                else
                {
                    sCharCount[s[i]] = 1;
                }

                if (tCharCount.ContainsKey(t[i]))
                {
                    tCharCount[t[i]]++;
                }
                else
                {
                    tCharCount[t[i]] = 1;
                }
            }

            foreach (var key in sCharCount.Keys)
            {
                if (!tCharCount.ContainsKey(key) || tCharCount[key] != sCharCount[key])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
