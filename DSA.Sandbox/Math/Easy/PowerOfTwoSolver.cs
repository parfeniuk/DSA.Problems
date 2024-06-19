namespace DSA.Sandbox.Math.Easy
{
    public static class PowerOfTwoSolver
    {
        // Solution using recursion
        // Time complexity: O(2^n)
        // Space complexity: O(n)
        public static int PowerOfTwo(int n)
        {
            if (n <= 0)
            {
                return 1;
            }

            return PowerOfTwo(n - 1) + PowerOfTwo(n - 1);
        }

        // Solution using iteration
        // Time complexity: O(n)
        // Space complexity: O(1)
        public static int PowerOfTwoIterative(int n)
        {
            int result = 1;

            for (int i = 0; i < n; i++)
            {
                result *= 2;
            }

            return result;
        }
    }
}
