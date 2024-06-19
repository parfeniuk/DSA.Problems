namespace DSA.Sandbox
{
    // Link to the problem - https://leetcode.com/problems/roman-to-integer/
    public static class RomanToIntegerSolver
    {
        // Given a roman numeral, convert it to an integer.
        // Example 1:
        // Input: s = "III"
        // Output: 3
        // Example 2:
        // Input: s = "IV"
        // Output: 4
        // Example 3:
        // Input: s = "IX"
        // Output: 9
        // Example 4:
        // Input: s = "LVIII"
        // Output: 58
        // Explanation: L = 50, V= 5, III = 3.
        // Example 5:
        // Input: s = "MCMXCIV"
        // Output: 1994
        // Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.

        // Constraints:
        // 1 <= s.length <= 15
        // s contains only the characters('I', 'V', 'X', 'L', 'C', 'D', 'M').
        // It is guaranteed that s is a valid roman numeral in the range[1, 3999].
        public static int RomanToInt(string s)
        {
            // Create a dictionary to store the value of each roman numeral
            var map = new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            // Initialize the result to 0
            var result = 0;

            // Iterate through the roman numeral string
            for (var i = 0; i < s.Length; i++)
            {
                // Get the value of the current roman numeral
                var value = map[s[i]];
                // If the current value is less than the next value, subtract the current value from the result
                if (i < s.Length - 1 && value < map[s[i + 1]])
                {
                    result -= value;
                }
                // Otherwise, add the current value to the result
                else
                {
                    result += value;
                }
            }
            return result;
        }
    }
}
