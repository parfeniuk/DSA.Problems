﻿namespace DSA.Sandbox.Recursion
{
    // Leetcode 231. Power of Two
    // Given an integer n, return true if it is a power of two. Otherwise, return false.
    // An integer n is a power of two, if there exists an integer x such that n == 2^x.
    // Constraints:
    // -2^31 <= n <= 2^31 - 1
    // Example 1:
    // Input: n = 1
    // Output: true
    // Explanation: 2^0 = 1
    // Example 2:
    // Input: n = 16
    // Output: true
    // Explanation: 2^4 = 16
    // Example 3:
    // Input: n = 3
    // Output: false
    // Example 4:
    // Input: n = 4
    // Output: true

    public static class PowerOfTwoSolver
    {
        public static bool IsPowerOfTwo(int n) 
        {
            if (n == 1) 
            {
                return true;
            }

            if (n == 0) 
            {
                return false;
            }

            if (n % 2 != 0) 
            {
                return false;
            }

            return IsPowerOfTwo(n / 2);
        } 
    }
}
