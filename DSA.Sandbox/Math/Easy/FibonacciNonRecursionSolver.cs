namespace DSA.Sandbox.Math.Easy
{
    public static class FibonacciNonRecursionSolver
    {
        // The Fibonacci numbers, commonly denoted F(n) form a sequence, called the Fibonacci sequence, such that each number is the sum of the two preceding ones, starting from 0 and 1.
        // That is, F(0) = 0, F(1) = 1
        // F(n) = F(n - 1) + F(n - 2), for n > 1
        // Given n, calculate F(n).
        // Constraints:
        // 0 <= n <= 30
        // Input: n = 2
        // Output: 1
        // Explanation: F(2) = F(1) + F(0) = 1 + 0 = 1
        // Input: n = 3
        // Output: 2
        // Explanation: F(3) = F(2) + F(1) = 1 + 1 = 2
        // Input: n = 4
        // Output: 3
        // Explanation: F(4) = F(3) + F(2) = 2 + 1 = 3

        // Approach:
        // 1. Base case: If n is 0, return 0. If n is 1, return 1.
        // 2. Initialize two variables to store the values of F(0) and F(1).
        // 3. Loop from 2 to n and calculate F(i) = F(i - 1) + F(i - 2).
        // 4. Update the values of F(0) and F(1) for the next iteration.
        // 5. Return the value of F(n).

        public static int CalculateFibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }

            int fib0 = 0;
            int fib1 = 1;
            int fib = 0;

            for (int i = 2; i <= n; i++)
            {
                fib = fib0 + fib1;
                fib0 = fib1;
                fib1 = fib;
            }

            return fib;
        }
    }
}
