using System.Diagnostics.Metrics;

namespace DSA.Sandbox
{
    // Leetcode 125. Valid Palindrome
    public static class ValidPalindromeSolver
    {
        // Write a function to determine if a string is a palindrome.
        // A palindrome is a word, phrase, number, or other sequence of characters that reads the same forward and backward.

        // Given a string s, return true if it is a palindrome, or false otherwise.
        // Example 1:
        
        // Input: s = "A man, a plan, a canal: Panama"
        // Output: true
        // Explanation: "amanaplanacanalpanama" is a palindrome.
        
        // Example 2:

        //Input: s = "race a car"
        //Output: false
        //Explanation: "raceacar" is not a palindrome.
        
        //Example 3:

        //Input: s = " "
        //Output: true
        //Explanation: s is an empty string "" after removing non-alphanumeric characters.
        //Since an empty string reads the same forward and backward, it is a palindrome.
        public static bool IsPalindrome(string s)
        {
            if (s is null) 
            {
                return false;
            }

            var input = new string(s.Select(char.ToLower).Where(char.IsLetterOrDigit).ToArray());

            if (input.Length == 0)
            {
                return true;
            }

            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }   
    }
}
