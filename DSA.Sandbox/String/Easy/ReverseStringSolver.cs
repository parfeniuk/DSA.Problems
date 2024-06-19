namespace DSA.Sandbox.String.Easy
{
    // Leetcode 344. Reverse String

    // Write a function that reverses a string. The input string is given as an array of characters s.
    // Constraints:
    // 1 <= s.length <= 10^5
    // s[i] is a printable ascii character
    // Input: s = ["h","e","l","l","o"]
    // Output: ["o","l","l","e","h"]
    public static class ReverseStringSolver
    {
        public static void ReverseString(char[] s)
        {
            if (s is null || s.Length == 0 || s.Length == 1)
            {
                return;
            }

            for (int i = 0; i < s.Length / 2; i++)
            {
                char left = s[i];
                s[i] = s[s.Length - i - 1];
                s[s.Length - i - 1] = left;
            }
        }


    }
}
